using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento
    public float fuerzaSalto = 3f; // Fuerza del salto
    private float fuerzaSaltoOriginal; // Para restaurar la fuerza de salto
    private Rigidbody2D rb;
    private bool isGrounded;
    private float movimiento;
    private bool mirandoDerecha = true; // Variable para saber en qué dirección está mirando
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        fuerzaSaltoOriginal = fuerzaSalto; // Guardamos la fuerza de salto original
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Captura la entrada de movimiento
        movimiento = Input.GetAxis("Horizontal");

        if (movimiento != 0f) {
            animator.SetBool("isRunning", true);
        } else {
            animator.SetBool("isRunning", false);
        }
        
        // Cambia la dirección del personaje si es necesario
        if (movimiento > 0 && !mirandoDerecha)
        {
            Voltear();
        }
        else if (movimiento < 0 && mirandoDerecha)
        {
            Voltear();
        }

        // Salto
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerzaSalto);
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        // Aplicar movimiento en FixedUpdate para mayor estabilidad
        rb.linearVelocity = new Vector2(movimiento * velocidad, rb.linearVelocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            fuerzaSalto = fuerzaSaltoOriginal; // Restaurar la fuerza de salto inmediatamente
        }

        if (collision.gameObject.CompareTag("Impulsor"))
        {
            isGrounded = true;
            fuerzaSalto = 18f;
        }
    }

    void Voltear()
    {
        mirandoDerecha = !mirandoDerecha; // Cambia la dirección
        Vector3 escala = transform.localScale;
        escala.x *= -1; // Invierte el personaje horizontalmente
        transform.localScale = escala;
    }
}