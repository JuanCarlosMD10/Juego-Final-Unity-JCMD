using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverOnCollision : MonoBehaviour
{
    public float restartDelay = 2f; // Tiempo antes de reiniciar el juego

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica si el objeto tocado tiene el tag "Obstaculo"
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            // Desactiva al personaje
            gameObject.SetActive(false);

            // Reinicia el juego después del retraso
            Invoke("RestartGame", restartDelay);
        }
    }

    void RestartGame()
    {
        // Reinicia la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}