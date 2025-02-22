using UnityEngine;

public class RotateOnX : MonoBehaviour
{
    public float rotationSpeed = 100f; // Adjust rotation speed as needed

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0, Space.Self);
    }
}
