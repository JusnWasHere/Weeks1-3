using UnityEngine;

public class RandomPos : MonoBehaviour
{
    Random rand = new Random();
    public float duration;
    float progress = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;

        if (progress >= duration)
        {
            Vector3 newPos = new Vector3(rand.Next(-10, 10), rand.Next(-10, 10), rand.Next(-10, 10));
            Debug.Log("Timer completed!");
            progress = 0f; // Reset the timer if you want it to repeat
        }

    }
}
