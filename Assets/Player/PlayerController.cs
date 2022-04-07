using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    [Range(10,1000)]
    public float jumpforce;
    private float moveInput;
    private Rigidbody2D rb;
    private SpriteRenderer sr;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        

        if (sr.flipX == true && moveInput > 0)
            sr.flipX = false;
        else if (sr.flipX == false && moveInput < 0)
            sr.flipX = true;

        if(Input.GetButtonDown("Jump")){
            rb.velocity = Vector2.up * jumpforce;            
        }

        
    }
}
