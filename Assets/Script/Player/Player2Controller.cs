using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    // PLayer 1 moves
    public float speed;
    private Rigidbody2D rb2d;
    public bool isFacingRight;
    private float player2Velocity;
    //private Animator anim

    //Jump
    public LayerMask whatIsGround;
    private float groundRadius;
    public Transform groundCheck;
    public bool isGrounded;
    public float jumpForce;

    //sounds
    //public AudioClip jumpSound;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        isFacingRight = false;
        groundRadius = 0.1f;
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
    }
    void Update()
    {
        //Moves
        player2Velocity = Input.GetAxisRaw("Horizontal2") * speed;

        if (player2Velocity > 0)
        {
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
            isFacingRight = true;
            FlipSprite();

        }
        else if (player2Velocity < 0)
        {
            rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
            isFacingRight = false;
            FlipSprite();
        }
        else
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y);
        }


        //Jump
        if (Input.GetButtonDown("Jump2") && isGrounded)
        {

            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
            /*
            if (jumpSound)
            {
                AudioSource.PlayClipAtPoint(jumpSound, transform.position);
            }
            */
        }

    }

    void FlipSprite()
    {
        if (isFacingRight)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (!isFacingRight)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    //Trigger STAY : colle au plateforme qui bouge
    void OnTriggerStay2D(Collider2D cible)
    {
        if (cible.tag == "Platform")
        {
            this.transform.parent = cible.transform;
        }
    }
    //Trigger EXIT : decolle au plateforme qui bouge
    void OnTriggerExit2D(Collider2D cible)
    {
        if (cible.tag == "Platform")
        {
            this.transform.parent = null;
        }
    }
}
