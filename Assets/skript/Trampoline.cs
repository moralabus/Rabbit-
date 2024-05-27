using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float bounceForce = 10f; // Сила отскока

    private Animator anim; // Аниматор батута

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Проверка, является ли объект, столкнувшийся с батутом, игроком
        if (collision.gameObject.CompareTag("Player"))
        {
            // Применение силы к игроку, чтобы оттолкнуть его от батута
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * bounceForce, ForceMode2D.Impulse);

            // Запуск анимации батута
            anim.SetTrigger("Bounce");
        }
    }
}
