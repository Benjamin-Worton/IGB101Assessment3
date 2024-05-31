using UnityEngine;

public class SpinModel : MonoBehaviour
{
    public float rotationSpeed = 30f; // Speed at which the model rotates

    void Update()
    {
        // Rotate the model around its y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
