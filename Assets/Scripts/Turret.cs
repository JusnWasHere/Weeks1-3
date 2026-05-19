using UnityEngine;
using UnityEngine.InputSystem;

public class Turret : MonoBehaviour
{
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool leftMouse = Mouse.current.leftButton.IsPressed();

        bool leftMousePressed = Mouse.current.leftButton.wasPressedThisFrame;
        bool leftMouseReleased = Mouse.current.leftButton.wasReleasedThisFrame;

        //Direction to B from A: B-A
        Vector3 directionToTarget = target.position - transform.position;
        transform.up = directionToTarget;
        
    }
}
