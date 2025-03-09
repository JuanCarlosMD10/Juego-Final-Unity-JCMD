using UnityEngine;

public class ActivadorMovimiento : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Personaje")) // Si el personaje choca con el activador
        {
            // Buscar todos los objetos con BarreraADesplazar y activarlos
            BarreraADesplazar[] barreras = FindObjectsByType<BarreraADesplazar>(FindObjectsSortMode.None);

            foreach (BarreraADesplazar barrera in barreras)
            {
                barrera.ActivarMovimiento(); // Activa el movimiento de todas las barreras
            }
        }
    }
}