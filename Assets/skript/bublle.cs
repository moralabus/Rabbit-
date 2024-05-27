using UnityEngine;
using System.Collections;

public class bublle : MonoBehaviour
{
    public float liftForce = 5f; // Сила подъема
    
    private Rigidbody2D collidedPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Проверка, является ли объект, столкнувшийся с мыльным пузырем, игроком
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collidedPlayer == null)
            {
                collidedPlayer = collision.gameObject.GetComponent<Rigidbody2D>();
                ApplyLift();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Проверка, является ли объект, покидающий мыльный пузырь, игроком
        if (collidedPlayer != null && collision.gameObject.CompareTag("Player"))
        {
            collidedPlayer = null;
            StopLift();
        }
    }

    private void ApplyLift()
    {
        // Применение силы к игроку, чтобы поднять его вверх
        collidedPlayer.AddForce(transform.up * liftForce, ForceMode2D.Impulse);
    }

    private void StopLift()
    {
        // Прекращение применения силы к игроку
        collidedPlayer.velocity = Vector2.zero;
    }

    private void FixedUpdate()
    {
        // Применение силы, пока игрок находится внутри пузыря и не прыгает
        if (collidedPlayer != null && collidedPlayer.velocity.y <= 0)
        {
            ApplyLift();
        }
        else
        {
            StopLift();
        }
    }
}
