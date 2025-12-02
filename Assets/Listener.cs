using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class Listener : MonoBehaviour
{
    public float texbubbleUptime = 10f;
    public float texbubbleDowntime = 10f;
    private bool crHasStarted = true;


    VMScript vmScript;

    GameObject canvas;
    public TMP_Text text;

    public AudioSource source;


    void Start()
    {
        vmScript = GameObject.Find("Volume Manager").GetComponent<VMScript>();
        canvas = GameObject.Find("DuckCanvas");

        canvas.SetActive(false);
        crHasStarted = false;
    }

    
    void Update()
    {
       

        if (!crHasStarted && vmScript.noiseVolume > 199 || !crHasStarted && vmScript.lightVolume > 199)
        {
            StartCoroutine(ActivateSpeachBubble());
        }

    }


    IEnumerator ActivateSpeachBubble()
    {
        crHasStarted = true;
        canvas.SetActive(true);


            if (vmScript.lightVolume < 200)
            {
                if (vmScript.noiseVolume > 199 && vmScript.noiseVolume < 700)
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light is fine at: " + vmScript.lightVolume.ToString() + "lm. However you should lower the noise around you. It is at: " + vmScript.noiseVolume.ToString() + "dB";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
                else
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light is fine at: " + vmScript.lightVolume.ToString() + "lm. However you should drasticly lower the noise around you. It is at: " + vmScript.noiseVolume.ToString() + "dB";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
            }

            else if (vmScript.lightVolume > 199 && vmScript.lightVolume < 700)
            {
                if (vmScript.noiseVolume < 200)
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light should be lowered. It is at: " + vmScript.lightVolume.ToString() + "lm. However the noise around you is fine at: " + vmScript.noiseVolume.ToString() + "dB";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
                else if (vmScript.noiseVolume > 199 && vmScript.noiseVolume < 700)
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light should be lowered. It is at: " + vmScript.lightVolume.ToString() + "lm. You should also lower the noise around you. It is at: " + vmScript.noiseVolume.ToString() + "dB";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
                else
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light should be lowered. it is at: " + vmScript.lightVolume.ToString() + "lm. You should also drasticly lower the noise around you. It is at: " + vmScript.noiseVolume.ToString() + "dB";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
            }

            else if (vmScript.lightVolume > 699)
            {
                if (vmScript.noiseVolume < 200)
                {

                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light should be drasticly lowered. it is at: " + vmScript.lightVolume.ToString() + "lm. However the noise around you is fine at: " + vmScript.noiseVolume.ToString() + "dB";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
                else if (vmScript.noiseVolume > 199 && vmScript.noiseVolume < 700)
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light should be drasticly lowered. it is at: " + vmScript.lightVolume.ToString() + "lm. You should also lower the noise around you. It is at: " + vmScript.noiseVolume.ToString() + "dB";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
                else
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light should be drasticly lowered. it is at: " + vmScript.lightVolume.ToString() + "lm. You should also drasticly lower the noise around you. It is at: " + vmScript.noiseVolume.ToString() + "dB";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
            }
    }
}
