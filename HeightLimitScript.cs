using Unity.VisualScripting;
using UnityEngine;

public class HeightLimitScript : MonoBehaviour
{
    private Player PlayerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other){
            if(other.gameObject.GetComponent<Player>()){
         PlayerScript = other.gameObject.GetComponent<Player>();
         PlayerScript.HeightLimitReached = true;    
    
            }

    }
    void OnTriggerExit(Collider other){
 if(other.gameObject.GetComponent<Player>()){
         PlayerScript = other.gameObject.GetComponent<Player>();
         PlayerScript.HeightLimitReached = false;    

    }

  }
    
}
