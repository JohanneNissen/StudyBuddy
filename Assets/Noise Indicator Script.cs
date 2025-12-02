using UnityEngine;

public class NoiseIndicatorScript : MonoBehaviour
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
        vmScript.noiseVolume = Mathf.Clamp(vmScript.noiseVolume, 0, 700);
        float t = vmScript.noiseVolume / 700f;
        Color newColor = Color.Lerp(Color.green, Color.yellow, t);
        newColor = Color.Lerp(newColor, Color.red, t);
        spriteRenderer.color = newColor;
    }
}
