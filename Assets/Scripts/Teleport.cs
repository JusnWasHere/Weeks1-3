using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float duration;
    float progress = 0f;
    public Vector3 newPosition;
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
            Debug.Log("Timer completed!");
            newPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 5f), 0f);
            transform.position = newPosition;
            progress = 0f;

        }


    }
}
