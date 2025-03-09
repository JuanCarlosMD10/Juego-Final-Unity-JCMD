using UnityEngine;

public class ObstaculoMovimientoVertical : MonoBehaviour
{
    public float amplitud = 1.5f; // Distancia máxima de movimiento vertical
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

        float nuevaY = posicionInicial.y + Mathf.Sin(Time.time * velocidad) * amplitud;
        rb.MovePosition(new Vector2(transform.position.x, nuevaY));
    }
}