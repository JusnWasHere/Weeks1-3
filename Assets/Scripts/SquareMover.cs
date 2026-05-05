using Unity.VisualScripting;
using UnityEngine;

public class SquareMover : MonoBehaviour
{
    Vector3 newPosition;
    public float speed = 0.03f;
    public float maxSpeed = 1f;
    public float acceleration = 1.001f;
    float xMax = 8.4f;
    float xMin = -8.4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        newPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        
        if(Mathf.Abs(speed) <= maxSpeed)
        {
           speed *= acceleration; // Increase speed by acceleration
        }

        if (newPosition.x >= xMax || newPosition.x <= xMin)
        {
            speed *= -1f; 
        }

        newPosition.x += speed;
        transform.position = newPosition; // Update the position of the GameObject

    }
}
