using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class Listener : MonoBehaviour
{
    public float texbubbleUptime = 10f;
    public float texbubbleDowntime = 10f;
    private bool crHasStarted = false;

    VMScript vmScript;

    GameObject canvas;
    public TMP_Text text;

    public AudioSource source;


    void Start()
    {
        vmScript = GameObject.Find("Volume Manager").GetComponent<VMScript>();
        canvas = GameObject.Find("DuckCanvas");
        //text = canvas.GetComponent<TextMeshPro>();
        canvas.SetActive(false);

        if (!crHasStarted)
        {
            StartCoroutine(ActivateSpeachBubble());   
        }

    }

    
    void Update()
    {
        
        if(!crHasStarted && vmScript.noiseVolume > 199)
        {
            StartCoroutine(ActivateSpeachBubble());
        }

    }


    IEnumerator ActivateSpeachBubble()
    {
        crHasStarted = true;
        canvas.SetActive(true);

        if (vmScript.noiseVolume > 199 && vmScript.noiseVolume < 700)
        {
            source.Play();
            text.text = " Noise between 200-700 ";
        }
        else if (vmScript.noiseVolume > 699)
        {
            source.Play();
            text.text = " Noise above 700 ";
        }
        else if (vmScript.lightVolume > 199 && vmScript.lightVolume < 700)
        {
            source.Play();
            text.text = " light between 200-700 ";
        }
        else if (vmScript.lightVolume > 699)
        {
            source.Play();
            text.text = " light above 700 ";
        }

        yield return new WaitForSeconds(texbubbleUptime);
        canvas.SetActive(false);
        
        yield return new WaitForSeconds(texbubbleUptime);
        crHasStarted = false;
    }
}
