using UnityEngine;

public class SeguirPersonaje : MonoBehaviour
{
    public Transform Personaje;  // El objeto que la cámara seguirá
    public float suavizado = 0.1f;  // Suavizado del movimiento de la cámara
    private Vector3 offset;  // Desplazamiento entre la cámara y el personaje

    void Start()
    {
        // Inicializamos el desplazamiento entre la cámara y el personaje
        offset = transform.position - Personaje.position;
    }

    void LateUpdate()
    {
        // Calcula la posición deseada de la cámara
        Vector3 posicionDeseada = Personaje.position + offset;

        // Suaviza el movimiento de la cámara
        Vector3 posicionSuavizada = Vector3.Lerp(transform.position, posicionDeseada, suavizado);

        // Aplica la nueva posición a la cámara
        transform.position = posicionSuavizada;
    }
}