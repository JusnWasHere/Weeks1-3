using UnityEngine;
using UnityEngine.InputSystem;

public class RollOver : MonoBehaviour
{
    public AnimationCurve curve;
    public Camera gameCamera;
    public float squareDistance;
    public bool timerIsRunning = false;
    float progress = 0f;
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
        //Debug.Log(distance);

        if (distance <= squareDistance)
        {
            //Debug.Log("in box");
            progress += Time.deltaTime;
            transform.localScale = curve.Evaluate(progress) * Vector3.one;
            timerIsRunning = true;
        }
        else
        {
            timerIsRunning= false;
            progress = 0f;
            Debug.Log(progress);
        }
    }
}
