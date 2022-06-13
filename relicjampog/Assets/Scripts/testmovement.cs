using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmovement : MonoBehaviour
{
    

    //All Char Vars
    public float speed = 10f;
    public float jumpPower = 15f;

    //Abilities
    public int extrajumps = 1; //dani double jump
    public int strength = 0; // lew strong grrr
    public int shrink = 1; //radlyns small
    public bool isshrunk = false;
    public int lightweight = 1; //Light footed
    public bool islight = false;


    //Physics and Ground
    [SerializeField] public LayerMask groundLayer;
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] Transform feet;
    [SerializeField] SpriteRenderer sprite;

    //Vars
    int jumpCount = 0;
    bool isGrounded;
    public float mx;
    float jumpCoolDown;

    //Animation
    public Animator spriteAnims;

    private void Update()
    {
        mx = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        CheckGrounded();
        FlipSprite();
        WalkingAnim();


        if(Input.GetKeyDown(KeyCode.LeftShift) && shrink == 1 && isshrunk == false)
        {
            StartCoroutine(shrinking());
        }

        if(Input.GetKeyDown(KeyCode.LeftShift) && lightweight == 1 && islight == false)
        {
            StartCoroutine(getslight());
        }

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
    void FlipSprite()
    {
        if(mx < 0)
        {
            sprite.flipX = true;
        }else if(mx > 0)
        {
            sprite.flipX = false;
        }
    }

    void WalkingAnim()
    {
        if(mx != 0)
        {
            spriteAnims.SetBool("isWalking", true);
        }else
        {
            spriteAnims.SetBool("isWalking", false);
        }
    }

    void StopWalking()
    {
        spriteAnims.SetBool("isWalking", false);
    }


    IEnumerator shrinking()
    {
        isshrunk = true;
        yield return new WaitForSeconds(0.0001f);
        Vector2 objectScale = transform.localScale;
        transform.localScale = new Vector2(objectScale.x * 0.5f, objectScale.y * 0.5f);
        jumpPower += 2f;   //Jump Boost for being tiny (You probably dont get the reference but its a super mario powerup)
        yield return new WaitForSeconds(2f);
        transform.localScale = new Vector2(objectScale.x * 1f, objectScale.y * 1f);
        jumpPower -= 2f;

        yield return new WaitForSeconds(2f); //Cooldown for shrink ability change if u want a diff cooldown
        isshrunk = false;
    }

    IEnumerator getslight()
    {
        islight = true;
        yield return new WaitForSeconds(0.0001f);
        rb.gravityScale -= 0.5f;
        yield return new WaitForSeconds(3f);
        rb.gravityScale = 1f;
        yield return new WaitForSeconds(2f); //cooldown
        islight = false;


    }



}
