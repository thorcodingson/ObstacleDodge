using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float xValue = 0f;

    [SerializeField]
    float yValue = 0.02f;

    [SerializeField]
    float zValue = 0f;

    void Start()
    {
        transform.Translate(1, 0, 0);
    }

    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
