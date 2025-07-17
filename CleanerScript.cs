using UnityEngine;

public class CleanerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit(Collider other){
         if(other.gameObject.name == "ObsCollider"){

            Destroy(other.transform.parent.gameObject,1);
         }


    }
}
