//using Unity.Mathematics;
//using System;
//using System;
//using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.WSA;

public class Tile : MonoBehaviour
{
    public float Obstacle2HeightAdj = 1.25f;
    public float Obstacle1HeightAdj = 1.25f;
    public Transform ObstacleSpawnPoint1;
    public Transform ObstacleSpawnPoint2 ;

    public Transform[] TreeSpawn;

    public Transform TreeSpawn1;
    public Transform TreeSpawn2;
    
    public Transform ObstacleSpawnPoint3;
    public float StreetLightSpawnControl = 1;

    public float GameStartObstacleWaitTime = 2f;
    bool Gamestart = true;


    bool LSpawned = false;
    bool MSpawned = false;
    bool RSpawned = false;
    public Transform SpawnPoint;
    public GameObject TilePrefab;
    private float rNumber;
    public GameObject CoinPrefab;
    public GameObject CactiPrefab;
    public GameObject TreePrefab;

    public GameObject ObstaclePrefab;
    public GameObject Obstacle2Prefab;
    public Transform StreetLightSpawn1;
    public Transform StreetLightSpawn2;
    public GameObject StreetlightPrefab;
    
  //  public GameObject SpawnBoxCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
        StartCoroutine(StartObstacleDelay());
     
      for(int i = 0; i<4; i++){
        SpawnTileV2();
    }
           
    }

    // Update is called once per frame
   public void SpawnTile(){
        GameObject NewTile = Instantiate(TilePrefab,SpawnPoint.position, Quaternion.identity); 
            SpawnPoint =  NewTile.transform.GetChild(1).transform;
           //  SpawnBoxCollider = NewTile.transform.GetChild(2).gameObject;
            ObstacleSpawnPoint1 = NewTile.transform.GetChild(3).transform;
            ObstacleSpawnPoint2 = NewTile.transform.GetChild(4).transform;
           rNumber = Random.Range(1,3);
      if(rNumber == 2){
                  rNumber = Random.Range(1,3);
              if(rNumber == 2){
                   GameObject Obstacle = Instantiate(ObstaclePrefab,ObstacleSpawnPoint2.position,Quaternion.identity);
              }else{GameObject Obstacle = Instantiate(Obstacle2Prefab,ObstacleSpawnPoint2.position,Quaternion.identity);}
      }else {
        rNumber = Random.Range(1,3);
              if(rNumber == 2){
        GameObject Obstacle = Instantiate(ObstaclePrefab,ObstacleSpawnPoint1.position,Quaternion.identity);
              }else{GameObject Obstacle = Instantiate(Obstacle2Prefab,ObstacleSpawnPoint1.position,Quaternion.identity);}
      }
  }

public void SpawnTileV2(){
  GameObject NewTile = Instantiate(TilePrefab,SpawnPoint.position, Quaternion.identity); 
            SpawnPoint =  NewTile.transform.GetChild(1).transform;

            ObstacleSpawnPoint1 = NewTile.transform.GetChild(3).transform;
            ObstacleSpawnPoint2 = NewTile.transform.GetChild(4).transform;
            ObstacleSpawnPoint3 = NewTile.transform.GetChild(5).transform;
            StreetLightSpawn1 = NewTile.transform.GetChild(7).transform;
            StreetLightSpawn2 = NewTile.transform.GetChild(8).transform;
            TreeSpawn1 = NewTile.transform.GetChild(9).transform;
            TreeSpawn2 = NewTile.transform.GetChild(10).transform;

     
     rNumber = Random.Range(0,2);
      if(Random.Range(0,2) == 1){ //For ObstacleSpawnPoint1
      //  GameObject Obstacle = Instantiate(ObstaclePrefab,ObstacleSpawnPoint1.position,Quaternion.identity);
           LSpawned = true;
      }else LSpawned = false;
      rNumber = Random.Range(0,2);
      if(Random.Range(0,2) == 1){//For ObstacleSpawnPoint2
           MSpawned = true;
      }else MSpawned = false;
      rNumber = Random.Range(0,2);
      if(Random.Range(0,2) == 1){//For ObstacleSpawnPoint3
           RSpawned = true;
      }else RSpawned = false;

      if(LSpawned == true && MSpawned == true && RSpawned == true){
       float rNumber  = Random.Range(1,4);
          if(rNumber == 1 && Gamestart == false){
                 GameObject Obstacle1 = Instantiate(ObstaclePrefab,ObstacleSpawnPoint1.position+ Vector3.up * Obstacle1HeightAdj,ObstaclePrefab.transform.rotation);
                 GameObject Obstacle2 =  Instantiate(Obstacle2Prefab,ObstacleSpawnPoint2.position+ Vector3.up * Obstacle2HeightAdj, Obstacle2Prefab.transform.rotation);
                 GameObject Obstacle3 = Instantiate(Obstacle2Prefab,ObstacleSpawnPoint3.position+ Vector3.up * Obstacle2HeightAdj, Obstacle2Prefab.transform.rotation); 
                 
          }if(rNumber == 2 && Gamestart == false){
                 GameObject Obstacle1 = Instantiate(Obstacle2Prefab,ObstacleSpawnPoint1.position+ Vector3.up * Obstacle2HeightAdj,Obstacle2Prefab.transform.rotation);
                 GameObject Obstacle2 =  Instantiate(ObstaclePrefab,ObstacleSpawnPoint2.position+ Vector3.up * Obstacle1HeightAdj, ObstaclePrefab.transform.rotation);
                 GameObject Obstacle3 = Instantiate(Obstacle2Prefab,ObstacleSpawnPoint3.position+ Vector3.up * Obstacle2HeightAdj,Obstacle2Prefab.transform.rotation); 
          }if(rNumber == 3 && Gamestart == false){
                 GameObject Obstacle1 = Instantiate(Obstacle2Prefab,ObstacleSpawnPoint1.position + Vector3.up * Obstacle2HeightAdj,Obstacle2Prefab.transform.rotation);
                 GameObject Obstacle2 =  Instantiate(Obstacle2Prefab,ObstacleSpawnPoint2.position + Vector3.up * Obstacle2HeightAdj, Obstacle2Prefab.transform.rotation);
                 GameObject Obstacle3 = Instantiate(ObstaclePrefab,ObstacleSpawnPoint3.position + Vector3.up *Obstacle1HeightAdj, ObstaclePrefab.transform.rotation); 
          }
      }else if(LSpawned == false && MSpawned == false && RSpawned == false){Debug.Log("ZeroCase");


      }
      
      else {
        if(LSpawned == true && Gamestart == false){GameObject Obstacle1s = Instantiate(Obstacle2Prefab,ObstacleSpawnPoint1.position+ Vector3.up * Obstacle2HeightAdj,Obstacle2Prefab.transform.rotation);}
        if(RSpawned == true && Gamestart == false){GameObject Obstacle2s = Instantiate(Obstacle2Prefab,ObstacleSpawnPoint2.position+ Vector3.up * Obstacle2HeightAdj,Obstacle2Prefab.transform.rotation);}
        if(MSpawned == true && Gamestart == false){GameObject Obstacle3s = Instantiate(Obstacle2Prefab,ObstacleSpawnPoint3.position+ Vector3.up * Obstacle2HeightAdj,Obstacle2Prefab.transform.rotation);}
      
        if(LSpawned == false)
        {rNumber = Random.Range(0,3);
        if(rNumber %2 == 0){
        // GameObject Coin = Instantiate(CoinPrefab,ObstacleSpawnPoint1.position+ Vector3.up * (3 + (Random.Range(-1,2)/2)),Quaternion.identity);
         

        }
        
        }
        if(MSpawned == false)
        {rNumber = Random.Range(0,3);
        if(rNumber %2 == 0){
         // GameObject Coin = Instantiate(CoinPrefab,ObstacleSpawnPoint2.position+ Vector3.up * (3 + (Random.Range(-1,2)/2)),Quaternion.identity);

        }
        
        }
        if(RSpawned == false)
        {rNumber = Random.Range(0,3);
        if(rNumber %2 ==0){
       //  GameObject Coin = Instantiate(CoinPrefab,ObstacleSpawnPoint3.position+ Vector3.up *  (3 + (Random.Range(-1,2)/2)),Quaternion.identity);
         

        }
        
        }
     
     
     
      }

     rNumber = Random.Range(0,8);

      if(rNumber % 3 == 0){
             GameObject Streetlight1 = Instantiate(CactiPrefab,StreetLightSpawn1.position,CactiPrefab.transform.rotation);
        

      }
      rNumber = Random.Range(0,8);

       if(rNumber % 3 == 0){
             
        GameObject Streelight2 = Instantiate(CactiPrefab, StreetLightSpawn2.position,CactiPrefab.transform.rotation * Quaternion.Euler(0,225,0));

      }
     

      
      rNumber = Random.Range(1,6);
      if(rNumber%3 == 0){


      }
      rNumber = Random.Range(0,6);
      if(rNumber%3 == 0){
     float RotRan = Random.Range(0,360);
         GameObject Tree1 = Instantiate(TreePrefab, TreeSpawn1.position,TreePrefab.transform.rotation * Quaternion.Euler(0,RotRan,0));
      }

      rNumber = Random.Range(0,6);
      if(rNumber%3 == 0){
     float RotRan = Random.Range(0,360);
          GameObject Tree2 = Instantiate(TreePrefab, TreeSpawn2.position,TreePrefab.transform.rotation * Quaternion.Euler(0,RotRan,0));
      }


}
public IEnumerator StartObstacleDelay(){
     Gamestart = true;
yield return new WaitForSeconds(GameStartObstacleWaitTime);
    Gamestart = false;
}
}
