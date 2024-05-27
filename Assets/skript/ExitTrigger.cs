using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    [SerializeField] private GameObject player; // Ссылка на игрока
    private bool exitCollected = false;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false; // Сделать выход невидимым изначально
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            if (player.GetComponent<hero>().coinsCollected >= 3 && !exitCollected)
            {
                // Действия, которые должны произойти при достижении выхода
                exitCollected = true;
                spriteRenderer.enabled = true; // Сделать выход видимым

                // Добавьте здесь код для окончания игры, например:
                // - Переход на следующую сцену
                // - Остановка игры
                // - Показ сообщения о победе 
            }
        }
    }
}
