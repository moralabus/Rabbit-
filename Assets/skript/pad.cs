using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pad : MonoBehaviour
{

    public float speed;
    public Vector3[] positions;

    private int currentTarget;

    public void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, positions[currentTarget], speed);
        if (transform.position == positions[currentTarget])
        {
            if (currentTarget +1 < positions.Length) 
            {
                currentTarget++;
            }
            else
            {
                currentTarget = 0;
            }
        }

    }
}
