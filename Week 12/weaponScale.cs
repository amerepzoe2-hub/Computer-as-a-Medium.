using UnityEngine;
using UnityEngine.InputSystem;

public class weaponScale : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            transform.localScale = new Vector3(-0.4186f, 0.4186f, 0.4186f);
        }
                if (Keyboard.current.dKey.isPressed)
        {
            transform.localScale = new Vector3(0.4186f, 0.4186f, 0.4186f);
        }
    }
}
