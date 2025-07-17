using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other){
    //    if(other.name != "Player_Mesh"){//Debug.Log(other);
      //  }
 if(other.name == "TruckCollider"){
          Time.timeScale= 0;
 
 }


    }
}
