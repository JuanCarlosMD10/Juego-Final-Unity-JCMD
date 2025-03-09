using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    void Update()
    {
        // Si el jugador presiona la tecla "Q", vuelve al menú
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("EscenaMenu");
        }
    }

    public void Jugar()
    {
        SceneManager.LoadScene("SampleScene"); // Carga la escena de juego
    }

    public void Salir()
    {
        Application.Quit(); // Cierra la aplicación (solo funciona en versión compilada)
    }
}