using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    Vector3 rotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 rotation = transform.eulerAngles;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;
        bool UpKey = Keyboard.current.upArrowKey.isPressed;
        bool DownKey = Keyboard.current.downArrowKey.isPressed;

        bool LeftKey = Keyboard.current.leftArrowKey.isPressed;
        bool RightKey = Keyboard.current.rightArrowKey.isPressed;

        if (DownKey)
            transform.position-= transform.up * moveSpeed * Time.deltaTime;
        else if (UpKey)
            transform.position += transform.up * moveSpeed * Time.deltaTime;

        if(LeftKey)
            rotation.z += rotateSpeed * Time.deltaTime;
        else if (RightKey)
            rotation.z -= rotateSpeed * Time.deltaTime;

 
        transform.eulerAngles = rotation;

    }
}
