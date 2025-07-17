using UnityEngine;

public class CoinColliderForPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }
    void OnTriggerEnter(Collider other){
     if(other.gameObject.GetComponent<PlayerCollider>()){
              
        Destroy(transform.gameObject);


     }


    }
    void OnCollisionEnter(Collision other){
        if(other.gameObject.GetComponent<PlayerCollider>()){
          Destroy(transform.gameObject);

        } 


    }
}
