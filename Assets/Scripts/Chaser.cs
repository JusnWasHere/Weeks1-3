using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Chaser : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Vector3 squarePosition;
    public Camera gameCamera;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();
        

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0f;
        transform.position = worldMousePosition;

    }
}
