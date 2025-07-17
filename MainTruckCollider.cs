using UnityEngine;

public class MainTruckCollider : MonoBehaviour
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
 if(other.gameObject.GetComponent<PlayerCollider>()){
  Time.timeScale = 0;

 }

    }
}
