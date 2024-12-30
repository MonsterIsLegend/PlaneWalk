using UnityEngine;

public class ARCameraMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float rotationSpeed = 0.1f; // Adjust sensitivity
    public float translationSpeed = 0.01f; // Speed of movement

    private Vector2 lastTouchPosition;
    private bool isDragging = false;

    void Update()
    {
        if (Input.touchCount == 1) // Single touch for camera movement
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                // Start dragging
                isDragging = true;
                lastTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved && isDragging)
            {
                // Handle dragging
                Vector2 deltaPosition = touch.position - lastTouchPosition;
                lastTouchPosition = touch.position;

                // Rotate camera around its local axes
                RotateCamera(deltaPosition);

                // Translate camera forward or backward
                TranslateCamera(deltaPosition);
            }
            else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
                // End dragging
                isDragging = false;
            }
        }
    }

    private void RotateCamera(Vector2 deltaPosition)
    {
        float rotationX = -deltaPosition.y * rotationSpeed;
        float rotationY = deltaPosition.x * rotationSpeed;

        // Apply rotation to camera
        transform.Rotate(rotationX, rotationY, 0, Space.Self);

        // Prevent unintended roll
        Vector3 currentRotation = transform.eulerAngles;
        transform.rotation = Quaternion.Euler(currentRotation.x, currentRotation.y, 0);
    }

    private void TranslateCamera(Vector2 deltaPosition)
    {
        float forwardBackward = -deltaPosition.y * translationSpeed;

        // Move camera forward/backward based on drag
        transform.Translate(0, 0, forwardBackward, Space.Self);
    }
}
