using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mosquito : MonoBehaviour
{
    public float speed;
    private bool dirRight = true;
    private float timer;
    public float moveTime;


    // Update is called once per frame
    void Update()
    {
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            
        }
        timer += Time.deltaTime;
        if (timer >= moveTime)
        {
            dirRight = !dirRight;
            timer = 0f;

        }

    }
}
