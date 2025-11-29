using UnityEngine;
using UnityEngine.Rendering;

public class Listener : MonoBehaviour
{


    VMScript vmScript;
    int switchCaseNR;
        
    
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
            
        }
        else if (vmScript.noiseVolume > 699)
        {
            switchCaseNR= 2;
        }

        switch (switchCaseNR)
        {
            case 0:
                Debug.Log("noise below 200");
                break;

            case 1:
                Debug.Log("noise between 200-700");
                break;
            case 2:
                Debug.Log("noise over 700");
                break;
        }
        
    }
}
