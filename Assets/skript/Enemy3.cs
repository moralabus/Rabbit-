using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy3 : MonoBehaviour
{
    public int count;

    public float speed;
    public Vector3[] positions;

    private int currentTarget;

    public void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, positions[currentTarget], speed);
        if (transform.position == positions[currentTarget])
        {
            if (currentTarget +1 < positions.Length) // Исправлено на positions.Length
            {
                currentTarget++;
            }
            else
            {
                currentTarget = 0;
            }
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Проверить, находится ли игрок сверху или сбоку
            if (collision.gameObject.transform.position.y >= transform.position.y)
            {
                // Игрок находится сверху, убить врага
                collision.gameObject.GetComponent<hero>().AddCoid(count);
                Destroy(gameObject);
            }
            else
            {
                // Игрок находится сбоку, убить игрока
                SceneManager.LoadScene(5);
            }
        }
    }
}

