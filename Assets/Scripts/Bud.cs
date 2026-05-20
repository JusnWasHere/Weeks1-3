using UnityEngine;
using UnityEngine.Rendering;

public class Bud : MonoBehaviour
{
    public GameObject bee;
    public GameObject petals;
    public float flowerDistance;
    Vector3 beePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        beePos = bee.transform.position;
        float distance = Vector3.Distance(beePos, transform.position);
        Debug.Log(distance);
        if (distance <= flowerDistance)
        {
            Debug.Log("reached");
            petals.gameObject.SetActive(true);
        }
    }
}

