using UnityEngine;
using UnityEngine.Rendering;

public class Listener : MonoBehaviour
{


    VMScript vmScript;
        
    void awake()
    {
       
        
    }
    
    void Start()
    {
        vmScript = GameObject.Find("Volume Manager").GetComponent<VMScript>();
    }

    
    void Update()
    {
        if (vmScript.noiseVolume > 200 && vmScript.noiseVolume < 700) 
        {
            Debug.Log("noise between 200-700"); 

        }
        else if (vmScript.noiseVolume > 700 )
        {
            Debug.Log("noise over 700");

        }
    }
}
