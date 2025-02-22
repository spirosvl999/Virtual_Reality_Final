using UnityEngine;

public class RotateOnXOnly : MonoBehaviour
{
    public float rotationSpeed = 100f;
    private float initialY;
    private float initialZ;
    private float currentX;

    void Start()
    {
        Vector3 initialRotation = transform.localEulerAngles;
        initialY = initialRotation.y;
        initialZ = initialRotation.z;
        currentX = initialRotation.x;
    }

    void Update()
    {
        currentX += rotationSpeed * Time.deltaTime;

        transform.localEulerAngles = new Vector3(currentX, initialY, initialZ);
    }
}
