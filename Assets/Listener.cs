using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class Listener : MonoBehaviour
{
    public float texbubbleUptime = 10f;
    private bool crHasStarted = false;

    VMScript vmScript;
    int switchCaseNR;

    Canvas canvas;
    TextMeshPro text;


    void Start()
    {
        vmScript = GameObject.Find("Volume Manager").GetComponent<VMScript>();
        canvas = gameObject.GetComponent<Canvas>();

        

        /*if (!crHasStarted)
        {
            
            text.enabled = true;
            StartCoroutine(ActivateSpeachBubble());
            
        }*/

    }

    
    void Update()
    {
        canvas.enabled = false;
        /*if(crHasStarted)
        {
            text.enabled = true;

            if (vmScript.noiseVolume > 199 && vmScript.noiseVolume < 700)
            {
                

            }
            else if (vmScript.noiseVolume > 699)
            {
                text.text = " Noise above 700 ";
            }

        }*/




    }


    IEnumerator ActivateSpeachBubble()
    {
        yield return new WaitForSeconds(texbubbleUptime);
        text.enabled = false;
        crHasStarted = false;

    }
}
