using UnityEngine;
using UnityEngine.Rendering;

public class Listener : MonoBehaviour
{


    VMScript vmScript;
    int switchCaseNR;
        
    void awake()
    {
       
        
    }
    
    void Start()
    {
        vmScript = GameObject.Find("Volume Manager").GetComponent<VMScript>();
    }

    
    void Update()
    {
        if(vmScript.noiseVolume < 200)
        {
            switchCaseNR = 0;
        }
        else if (vmScript.noiseVolume > 199 && vmScript.noiseVolume < 700)
        {
            switchCaseNR = 1;
            Debug.Log("noise between 200-700");

        }
        else if (vmScript.noiseVolume > 700)
        {
            Debug.Log("noise over 700");

        }

        switch (switchCaseNR)
        {
            case 1:
                break;

            case 0;
        }
        
    }
}
