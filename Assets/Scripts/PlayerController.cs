using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float runSpeed = 15;
    public float jumpForce = 1;
    public Rigidbody2D rb;
    public Animator anim;
    // Start is called before the first frame update
    public bool isGrounded;
    public SpriteRenderer spriteRenderer;

    public GroundChecker groundChecker;
    public PlayerStats stats;
    
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       anim = GetComponent<Animator>();
       spriteRenderer = GetComponent<SpriteRenderer>();
       stats = GetComponent<PlayerStats>();
    }


    // Update is called once per frame
    void Update()
    {
        if(stats.isDead) return;
     
      float moveInput = Input.GetAxis("Horizontal"); 
      //Debug.Log($"Input pressed: {moveInput}");
      if(moveInput < 0)
      {
          spriteRenderer.flipX = true;
      }
      else
      {
          spriteRenderer.flipX = false;
      }

      

      if(moveInput !=0)
      {
          anim.SetBool("isWalking",true);
      }

      else
      {
          anim.SetBool("isWalking",false);
      }
      
      if(Input.GetKey(KeyCode.LeftShift))
      {
        
         rb.velocity = new Vector2(moveInput * runSpeed, rb.velocity.y);

      }
      
      
      else
      
      {
          
          rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
      }


      if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //rb.AddForce(Vector2.up * jumpForce);
            anim.SetBool("IsJumping", true); 
        }

       
        anim.SetBool("IsJumping", !isGrounded);
      
        
      if (Input.GetKeyDown(KeyCode.Space))
      {
          
          rb.AddForce( Vector2.up * jumpForce );

      }
      
      
     }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log($"Object is colliding with: {collision.gameObject}");
        isGrounded = true;

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
        isGrounded = false;
    }
}
