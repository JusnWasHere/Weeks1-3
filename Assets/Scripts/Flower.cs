using UnityEngine;

public class Flower : MonoBehaviour
{
    public AnimationCurve curve;

    Vector3 beePos;

    public float duration;

    private float progress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(beePos, transform.position);
        Debug.Log(distance);
        progress += Time.deltaTime;
        transform.localScale = curve.Evaluate(progress / duration) * Vector3.one;
    }
}


