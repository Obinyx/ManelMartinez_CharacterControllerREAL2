using UnityEngine;

public class ZonaMuerte : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Comprobamos si el objeto que entra es el Jugador
        if (other.CompareTag("Player") || other.gameObject.name == "Player")
        {
            // 1. Activamos la animación de muerte
            Animator anim = other.GetComponent<Animator>();
            if (anim != null)
            {
                anim.SetTrigger("IsDead");
            }

            // 2. Desactivamos el script de movimiento para que no se pueda mover más
            PlayerController movimiento = other.GetComponent<PlayerController>();
            if (movimiento != null)
            {
                movimiento.enabled = false;
            }
        }
    }
}