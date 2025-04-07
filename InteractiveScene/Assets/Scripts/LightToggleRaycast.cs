using UnityEngine;

public class LightToggleRaycast : MonoBehaviour
{
    public Transform cameraTransform; // Referencia a la c�mara del jugador
    public float maxRayDistance = 10f; // Distancia m�xima del Raycast
    public LayerMask interactableLayer; // Capa de objetos interactuables

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Presionar "E" para interactuar
        {
            Ray ray = new Ray(cameraTransform.position, cameraTransform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, maxRayDistance, interactableLayer))
            {
                Light lightComponent = hit.collider.GetComponent<Light>();
                if (lightComponent != null)
                {
                    lightComponent.enabled = !lightComponent.enabled; // Encender/Apagar luz
                }
            }
        }
    }
}
