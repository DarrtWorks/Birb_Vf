using UnityEngine;

public class TruckCoinDebug : MonoBehaviour
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
    if(other.GetComponent<CoinScript>()){
        Destroy(other.gameObject);


    }


    }
}
