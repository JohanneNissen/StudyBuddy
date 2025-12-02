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
        float t = vmScript.lightVolume / 700f;
        Color newColor = Color.Lerp(Color.green, Color.yellow, t);
        newColor = Color.Lerp(newColor, Color.red, t);
        spriteRenderer.color = newColor;
    }
}
