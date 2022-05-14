using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishingBlock : MonoBehaviour
{
    private Animator anim;
    public float vanishingTime;
    
    private BoxCollider2D boxColl;

    // Start is called before the first frame update
    void Start()
    {
        boxColl = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke("Vanishing", vanishingTime);
        }   


    }

    void Vanishing()
    {
        anim.SetTrigger("step");
        boxColl.isTrigger = true;
        Invoke("Die", 1);
    }

    void Die()
    {
        Destroy(gameObject);
    }
}