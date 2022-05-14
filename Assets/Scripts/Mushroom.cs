using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public float jumpForce;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetTrigger("jump");
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            
        }

    }
}
