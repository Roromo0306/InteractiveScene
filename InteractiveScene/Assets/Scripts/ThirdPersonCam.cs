using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCam : MonoBehaviour
{
    public Transform target; // Personaje a seguir
    public Vector3 offset = new Vector3(0, 3, -5);
    public float mouseSensitivity = 100f;

    private float yaw = 0f;
    private float pitch = 0f;

    public float minPitch = -20f; // Límite de cámara hacia abajo
    public float maxPitch = 60f;  // Límite de cámara hacia arriba

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Oculta el cursor
    }

    private void LateUpdate()
    {
        // Obtener movimiento del mouse
        yaw += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        pitch = Mathf.Clamp(pitch, minPitch, maxPitch);

        // Rotar la cámara
        transform.position = target.position + Quaternion.Euler(pitch, yaw, 0) * offset;
        transform.LookAt(target.position);
    }
}


