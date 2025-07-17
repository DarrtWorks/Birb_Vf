using UnityEngine;

public class ObstacleModelScript : MonoBehaviour
{
    public float ObstacleRandomSpeedMultiplier = 100f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake(){
         rb= transform.gameObject.GetComponent<Rigidbody>();
         rb.linearVelocity = Vector3.back* Time.deltaTime * Random.Range(10,15)* ObstacleRandomSpeedMultiplier;

    }
}
