using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if(Input.GetKeyDown(KeyCode.H)){

    Time.timeScale = 0;

        
    }
    if(Input.GetKeyUp(KeyCode.H)){

        Time.timeScale = 1;
    }
    
    }


    }

