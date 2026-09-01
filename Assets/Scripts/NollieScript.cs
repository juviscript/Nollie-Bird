using UnityEngine;
using UnityEngine.InputSystem;

public class NollieScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float jumpStrength = 22f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            print("Space key was pressed");
            rigidBody.linearVelocityY = jumpStrength;
        }
    }
}
