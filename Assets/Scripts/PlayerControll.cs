using UnityEngine;

public class SubmarineController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;

    [Header("Camera Settings")]
    public Transform cameraTransform;
    public Vector3 cameraOffset = new Vector3(0, 20, -10); // posisi kamera di atas

    void Update()
    {
        HandleMovement();
        HandleCameraFollow();
    }

    void HandleMovement()
    {
        // Maju mundur (W/S)
        float moveInput = Input.GetAxis("Vertical"); // W = 1, S = -1
        transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);

        // Rotasi kiri/kanan (A/D)
        float turnInput = Input.GetAxis("Horizontal"); // A = -1, D = 1
        transform.Rotate(Vector3.up * turnInput * rotationSpeed * Time.deltaTime);
    }

    void HandleCameraFollow()
    {
        if (cameraTransform != null)
        {
            // Kamera mengikuti posisi submarine
            cameraTransform.position = transform.position + cameraOffset;
            cameraTransform.LookAt(transform.position); // kamera selalu melihat ke submarine
        }
    }
}

