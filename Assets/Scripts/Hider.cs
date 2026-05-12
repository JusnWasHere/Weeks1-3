using UnityEngine;
using UnityEngine.InputSystem;
public class Hider : MonoBehaviour
{
    public Vector3 hidePosition;
    public Camera gameCamera;
    public float hideDistance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0f;

        float distance = Vector3.Distance(worldMousePosition, transform.position);
        Debug.Log(distance);
        if (distance < hideDistance)
        {
            transform.position = hidePosition;
        }
        

    }
}
