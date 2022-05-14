using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider_H_up : MonoBehaviour
{
    private bool moveRight = true;

    public float velocidade = 3f;
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
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - velocidade * Time.deltaTime, transform.position.y);
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }
    }
}
