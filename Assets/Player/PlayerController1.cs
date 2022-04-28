using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float speed;
    public float jumpforce;
    private float moveInput;
    public bool canMove = true;
    public float disabled;
    private Rigidbody2D rb;

    private bool facingRight = true;
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;


    private int extraJumps;
    public int extraJumpsValue;

    void Start(){
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate(){

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        if (canMove == true)
        {
            moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
            disabled = 0;
        }
        if (canMove == false && disabled > 2)
        {
            moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * 5, rb.velocity.y);
        }

        if (facingRight == false && moveInput > 0){ 
            Flip();
        } else if (facingRight == true && moveInput < 0){
            Flip();
        }
    }

     void Update(){
        if (canMove == false)
        {
            disabled += Time.deltaTime;
            Debug.Log(disabled);
        }
        if (isGrounded == true){
            extraJumps = extraJumpsValue;
            canMove = true;
        }

        bool Up = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space);
        if (Up && extraJumps > 0){
            rb.velocity = Vector2.up * jumpforce;
            extraJumps--;
        } else if(Up && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpforce;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isGrounded == false)
        {

            if (collision.gameObject.tag == "CPlat" || collision.gameObject.tag == "finish")
            {
                canMove = false;
            }
        }
    }
}
