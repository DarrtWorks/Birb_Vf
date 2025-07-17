//using System.Numerics;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
//using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
   public float ForwardSpeed = 20f;
   public float JumpHeight = 1.3f;
   public float Sensitivity = 0.25f;
   public float TiltSensitivity = 0.25f;
   public float SlerpSmoothness = 1f; 
   private InputMaster InputMaster;
   private bool OnGround = false;
   public LayerMask Ground;
   public float Gravity  = -9.8f;
   private Vector3 VelocityY;
   public Transform CheckSphereGround;
   public float CheckSphereGroundRadius = 6f;

   private CharacterController controller;
   public float EnergyCount; 
   public float MaxEnergy = 5f;
   private bool EnergyDelayTrue;
   public bool HeightLimitReached = false;
    
    void Awake(){
      InputMaster = new InputMaster();
      controller = GetComponent<CharacterController>();
      
    }
    void OnEnable(){
        InputMaster.Enable();
    }
    void OnDisable(){
        InputMaster.Disable();
    }
    void Start()
    {
       EnergyCount = 5f;
       Cursor.lockState = CursorLockMode.Locked;
        
    }

    
    void Update()
    {  OnGround = Physics.CheckSphere(CheckSphereGround.position,CheckSphereGroundRadius,Ground);

        Vector2 MouseInput = InputMaster.Player.MouseInput.ReadValue<Vector2>(); 

        //Debug.Log(MouseInput);
        //Debug.Log(OnGround);
        
        float Mouse_X = -MouseInput.x * Time.deltaTime;

       if(OnGround == false){ controller.Move(Vector2.left * Mouse_X * Sensitivity);}

        Quaternion Z_Rotation = Quaternion.AngleAxis((Mouse_X * TiltSensitivity), Vector3.forward);

        Quaternion TargetAngle = Z_Rotation;


       if(OnGround == false){ transform.localRotation = Quaternion.Slerp(transform.localRotation,TargetAngle,SlerpSmoothness);}
    //controller.Move(Vector3.right * Mouse_X * 10);   


       if(OnGround && VelocityY.y < 0){
      
              VelocityY.y = -2f;
       
       }   
       
       if(InputMaster.Player.Jump.triggered /*&&  EnergyCount != 0*/ && HeightLimitReached == false){
            VelocityY.y = Mathf.Sqrt(-2f * Gravity * 1.3f);
            EnergyCount -=1;
         //   Debug.Log(EnergyCount);

       }
       
       if(EnergyCount < 5 && EnergyDelayTrue == false){
         StartCoroutine(EnergyDelay());
       }  
       
       
       
        VelocityY.y += Gravity * Time.deltaTime;

       controller.Move(VelocityY * Time.deltaTime);
       controller.Move(transform.forward * ForwardSpeed * Time.deltaTime);

     
    }
    private IEnumerator EnergyDelay(){
      EnergyDelayTrue = true;
      yield return new WaitForSeconds(1.2f); 
      EnergyCount +=1;
     // Debug.Log("COROUTINE RUN");
      EnergyDelayTrue = false;  

    }
    
    
}
