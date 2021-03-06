using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_H : MonoBehaviour
{
    private bool moveRight = true;

    public float velocidade = 1.5f;
    public Transform pontoA;
    public Transform pontoB;

    void Update()
    {
        if(transform.position.x < pontoA.position.x)    
        {
            moveRight = true;
        }
        if(transform.position.x > pontoB.position.x)
        {
            moveRight = false;
        }
        if(moveRight)
        {
            transform.position = new Vector2(transform.position.x + velocidade * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - velocidade * Time.deltaTime, transform.position.y);
        }
    }
}
