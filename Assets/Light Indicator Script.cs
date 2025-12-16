using UnityEngine;

public class LightIndicatorScript : MonoBehaviour
{
    VMScript vmScript;
    private SpriteRenderer spriteRenderer;


    void Start()
    {

        vmScript = GameObject.Find("Volume Manager").GetComponent<VMScript>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }


    void Update()
    {
        vmScript.lightVolume = Mathf.Clamp(vmScript.lightVolume, 0, 700);
        int v = vmScript.lightVolume;

        Color newColor;

        if (v < 100)
        {
            // Red → Yellow
            float t = v / 100f;
            newColor = Color.Lerp(Color.red, Color.yellow, t);
        }
        else if (v < 200)
        {
            // Yellow → Green
            float t = (v - 100) / 100f;
            newColor = Color.Lerp(Color.yellow, Color.green, t);
        }
        else if (v < 500)
        {
            // Solid Green
            newColor = Color.green;
        }
        else if (v < 600)
        {
            // Green → Yellow
            float t = (v - 500) / 100f;
            newColor = Color.Lerp(Color.green, Color.yellow, t);
        }
        else
        {
            // Yellow → Red
            float t = (v - 600) / 100f;
            newColor = Color.Lerp(Color.yellow, Color.red, t);
        }

        spriteRenderer.color = newColor;
    }
}
