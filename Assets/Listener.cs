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
       

        if (!crHasStarted && vmScript.noiseVolume > 199 || !crHasStarted && vmScript.lightVolume < 199 || !crHasStarted && vmScript.lightVolume > 499)
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
            Debug.Log("imhere");
                if (vmScript.noiseVolume < 200)
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light is too low at: " + vmScript.lightVolume.ToString() + "lx, which might strain your eyes.";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }

                else if (vmScript.noiseVolume > 199 && vmScript.noiseVolume < 700)
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light is too low at: " + vmScript.lightVolume.ToString() + "lx, which might strain your eyes. You should also lower the ambient noise around you.";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
                else
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light is too low at: " + vmScript.lightVolume.ToString() + "lx, which might strain your eyes. You should also drasticly lower the ambient noise around you.";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
            }

            else if (vmScript.lightVolume > 199 && vmScript.lightVolume < 500)
            {
                 if (vmScript.noiseVolume > 199 && vmScript.noiseVolume < 700)
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "You should lower the ambient noise around you.";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
                else
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "You should drasticly lower the ambient noise around you.";

                yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
            }

            else if (vmScript.lightVolume > 499)
            {
                if (vmScript.noiseVolume < 200)
                {

                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light should be drasticly lowered. It is at: " + vmScript.lightVolume.ToString() + "lx.";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
                else if (vmScript.noiseVolume > 199 && vmScript.noiseVolume < 700)
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light should be drasticly lowered. It is at: " + vmScript.lightVolume.ToString() + "lx. You should also lower the ambient noise around you.";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
                else
                {
                    source.pitch = Random.Range(0.9f, 1.1f);
                    source.Play();
                    text.text = "Your sorrounding light should be drasticly lowered. It is at: " + vmScript.lightVolume.ToString() + "lx. You should also drasticly lower the ambient noise around you.";

                    yield return new WaitForSeconds(texbubbleUptime);
                    canvas.SetActive(false);

                    yield return new WaitForSeconds(texbubbleDowntime);
                    crHasStarted = false;
                }
            }
    }
}
