using UnityEngine;

public class CoinColliderScript : MonoBehaviour
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
  if(other.gameObject.GetComponent<ObstacleModelScript>()){
         Rigidbody rb = transform.parent.gameObject.GetComponent<Rigidbody>();
      rb.linearVelocity = other.gameObject.GetComponent<Rigidbody>().linearVelocity;


  }


    }
}
