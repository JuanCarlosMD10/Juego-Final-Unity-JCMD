using UnityEngine;

public class ObstaculoMovimientoHorizontal : MonoBehaviour
{
    public float amplitud = 3f; // Distancia máxima de movimiento horizontal
    public float velocidad = 2f; // Velocidad del movimiento

    private Vector3 posicionInicial;
    private Rigidbody2D rb;

    void Start()
    {
        posicionInicial = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (rb == null) return;

        float nuevaX = posicionInicial.x + Mathf.Sin(Time.time * velocidad) * amplitud;
        rb.MovePosition(new Vector2(nuevaX, transform.position.y));
    }
}