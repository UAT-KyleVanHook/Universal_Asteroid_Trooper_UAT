using Unity.VisualScripting;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public KeyCode keyToUse;
    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToUse))
        {
            //TODO: Change the Sprite Color
            Color newColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
            spriteRenderer.color = newColor;
        }
       
    }
}
