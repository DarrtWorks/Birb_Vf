using Unity.VisualScripting;
using UnityEngine;

public class CleanerScriptGen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionExit(Collision other){
        if(other.gameObject.name=="Cleaner"){
            Destroy(transform.gameObject, 1);
        }

    }
}
