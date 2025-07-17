using System;
using Unity.VisualScripting;
using UnityEngine;

public class RespawnCollider : MonoBehaviour
{
    private Tile TileScript;
    private Player PlayerScript;
    public float PlayerSpeedIncrement = 0.6f;
    
    private  GameObject Parent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        TileScript = GameObject.Find("TileControl").GetComponent<Tile>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

       void OnTriggerEnter(Collider other){
       
       if(other.transform.gameObject.GetComponent<Player>()){
        TileScript.SpawnTileV2();
        PlayerScript = other.transform.GetComponent<Player>();
        if(PlayerScript.ForwardSpeed < 35){
        PlayerScript.ForwardSpeed += PlayerSpeedIncrement;}
        Destroy(transform.parent.gameObject, 2);
        


       }



    }
}
