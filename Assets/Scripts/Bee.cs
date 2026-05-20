using UnityEngine;
using UnityEngine.InputSystem;

public class Bee : MonoBehaviour
{
    public float duration;
    float progress = 0f;

    public Camera gameCamera;

    public Vector3 startValue;
    public Vector3 endValue;

    public Vector3 currentValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0f;

        currentValue = Vector3.Lerp(startValue, endValue, progress / duration);
        transform.position = currentValue;
        float distance = Vector3.Distance(worldMousePosition, transform.position);
        if (progress >= duration)
        {
            progress = 0f;
            startValue = transform.position;
            endValue = worldMousePosition;

        }

    }
}
