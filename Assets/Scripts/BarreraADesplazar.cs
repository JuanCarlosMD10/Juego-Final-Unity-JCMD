using UnityEngine;

public class BarreraADesplazar : MonoBehaviour
{
    public float velocidad = 8f; // Velocidad de desplazamiento
    private bool mover = false; // Bandera para iniciar el movimiento

    void Update()
    {
        if (mover)
        {
            transform.position += Vector3.right * velocidad * Time.deltaTime;
        }
    }

    public void ActivarMovimiento()
    {
        mover = true; // Se activa cuando el personaje toca el activador
    }
}