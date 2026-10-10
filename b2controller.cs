using UnityEngine;

public class B2Controller : MonoBehaviour
{
    [Header("UI Controls")]
    public Joystick joystick;

    [Header("Movement Settings")]
    public float moveSpeed = 1.5f;
    public float rotationSpeed = 120f;

    void Update()
    {
        if (joystick == null) return;

        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical);

        if (moveDirection.magnitude >= 0.1f)
        {
            // Move relative to current facing direction
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.Self);

            // Rotate smoothly toward movement direction
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * (rotationSpeed / 10f));
        }
    }
}