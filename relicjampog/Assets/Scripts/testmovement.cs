using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmovement : MonoBehaviour
{
    //All Char Vars
    public float speed = 10f;
    public float jumpPower = 15f;

    //Abilities
    public int extrajumps = 1;

    //Physics and Ground
    [SerializeField] public LayerMask groundLayer;
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] Transform feet;

    int jumpCount = 0;
    bool isGrounded;
    float mx;
    float jumpCoolDown;

    private void Update()
    {
        mx = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        CheckGrounded();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(mx * speed, rb.velocity.y);
    }
    void Jump ()
    {
        if (isGrounded || jumpCount < extrajumps)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            jumpCount++;
        }
    }
    void CheckGrounded()
    {
        if(Physics2D.OverlapCircle(feet.position,0.5f,groundLayer))
        {
            isGrounded = true;
            jumpCount = 0;
            jumpCoolDown = Time.time + 0.2f;
        }else if(Time.time<jumpCoolDown)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }     
    }
}
