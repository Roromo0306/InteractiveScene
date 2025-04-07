using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    public Rigidbody rb;
    public Transform cameraTransform; // Referencia a la c�mara
    public float moveSpeed = 6f;
    public float rotationSpeed = 720f; // Velocidad de rotaci�n

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontal, 0, vertical).normalized;

        if (moveDirection.magnitude >= 0.1f)
        {
            // Rotar el movimiento seg�n la c�mara
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg + cameraTransform.eulerAngles.y;
            Quaternion targetRotation = Quaternion.Euler(0, targetAngle, 0);
            rb.rotation = Quaternion.RotateTowards(rb.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);

            // Aplicar movimiento con f�sica
            Vector3 moveDir = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
            rb.velocity = moveDir * moveSpeed + new Vector3(0, rb.velocity.y, 0);
        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0); // Mantener gravedad
        }
    }
}


