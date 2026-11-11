using UnityEngine.InputSystem;
using TMPro;
using UnityEngine;

public class Mana : MonoBehaviour
{
    public Animator animator;
    public int manaNum = 30;
    public TMP_Text manaText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + manaNum;
    }

    // Update is called once per frame
    void Update()
    {
        manaText.text = "Mana: " + manaNum;
        ManaUse();
    }
    void ManaUse()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            manaNum = manaNum - 10;
            animator.SetBool("mana", true);
        }
        else
        {
            animator.SetBool("mana", false);
        }
    }
}