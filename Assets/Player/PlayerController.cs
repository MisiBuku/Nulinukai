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
    public int jumpCountValue;
    private int jumpCount;
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public AudioSource myFx;
    public AudioSource myFx2;
    public AudioClip jumpFx;
    public AudioClip coinFx;


    // Start is called before the first frame update
    void Start()
    {
        jumpCount = jumpCountValue;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate(){

        

    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Coins")){
            Destroy(other.gameObject);
            myFx2.PlayOneShot(coinFx);
        }

    }
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        
        
        if(Input.anyKey){
            
        }

        if (sr.flipX && moveInput > 0)
            sr.flipX = false;
        else if (!sr.flipX && moveInput < 0)
            sr.flipX = true;

        if(Input.GetButtonDown("Jump") && jumpCount > 0){
            jumpCount--;      
            rb.velocity = Vector2.up * jumpforce;
            myFx.PlayOneShot(jumpFx);
        }
        else if(Input.GetButtonDown("Jump") && isGrounded){
                        rb.velocity = Vector2.up * jumpforce;
            myFx.PlayOneShot(jumpFx);
        }
        if(isGrounded)
        {
            jumpCount = jumpCountValue;
        }

        
    }
}
