using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class grass7: MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Проверка, является ли объект, столкнувшийся с кактусом, игроком
        if (other.gameObject.CompareTag("Player"))
        {
            // Уничтожение игрока
            SceneManager.LoadScene(6);
        }
    }
}
