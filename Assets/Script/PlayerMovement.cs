using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    Rigidbody2D rb; 
    bool isGrounded = false; 
    public Transform isGroundedChecker; 
    public Transform isGroundedChecker2; 
    public Transform isGroundedChecker3; 
    public float checkGroundRadius; 
    public LayerMask groundLayer;
    public float fallMultiplier = 2.5f; 
    public float lowJumpMultiplier = 2f;
    public float rememberGroundedFor; 
    float lastTimeGrounded;
    public int defaultAdditionalJumps = 1; 
    int additionalJumps;
    public Animator animator;
    public TMP_Text TextOnPlayerHead;
    bool buttonpressed;
    bool attacked;
    public List<AttackColliderTest> AttackColliderTest;

    void Start() 
    { 
        rb = GetComponent<Rigidbody2D>(); 
    }
    void Update() 
    { 
        Move();
        Jump();
        BetterJump();
        CheckIfGrounded();
        Attack();        
    } 
    void Move() 
    { 
        float x = Input.GetAxisRaw("Horizontal"); 
        float moveBy = x * speed; 
        rb.velocity = new Vector2(moveBy, rb.velocity.y); 
        animator.SetFloat("Speed", Mathf.Abs(moveBy));
    }
    void Jump() 
    {
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || Time.time - lastTimeGrounded <= rememberGroundedFor || additionalJumps > 0)) 
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            additionalJumps--;
            
        }
    }
    void BetterJump() 
    {
        if (rb.velocity.y < 0) 
        {
            rb.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
            
        } 
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space)) 
        {
            rb.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
            
        }   
    }
    void CheckIfGrounded() 
    {
        Collider2D colliders = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);
        if (colliders != null) 
        {
            isGrounded = true;
            additionalJumps = defaultAdditionalJumps;
            animator.SetBool("IsJumping", false);
        } 
        else 
        {
            if (isGrounded) 
            {
                lastTimeGrounded = Time.time;
                
            }
            isGrounded = false;
            animator.SetBool("IsJumping", true);
        }
        Collider2D colliders2 = Physics2D.OverlapCircle(isGroundedChecker2.position, checkGroundRadius, groundLayer);
        if (colliders2 != null) 
        {
            isGrounded = true;
            additionalJumps = defaultAdditionalJumps;
            animator.SetBool("IsJumping", false);
        } 
        else 
        {
            if (isGrounded) 
            {
                lastTimeGrounded = Time.time;
                
            }
            isGrounded = false;
            animator.SetBool("IsJumping", true);
        }
        Collider2D colliders3 = Physics2D.OverlapCircle(isGroundedChecker3.position, checkGroundRadius, groundLayer);
        if (colliders3 != null) 
        {
            isGrounded = true;
            additionalJumps = defaultAdditionalJumps;
            animator.SetBool("IsJumping", false);
        } 
        else 
        {
            if (isGrounded) 
            {
                lastTimeGrounded = Time.time;
                
            }
            isGrounded = false;
            animator.SetBool("IsJumping", true);
        }
    }
    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.J)&&attacked==false)
        {
            animator.SetBool("IsAttacking1", true);
            AttackColliderTest[0].attacked=true;
            attacked=true;
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            animator.SetBool("IsAttacking1", false);

        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetBool("IsAttacking2", true);
            AttackColliderTest[1].attacked=true;
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            animator.SetBool("IsAttacking2", false);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            animator.SetBool("IsUsingPower", true);
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            animator.SetBool("IsUsingPower", false);
        }
    }
     public void AlertObservers(string message)
    {
        if (message.Equals("Attack1AnimationEnded"))
        {
            AttackColliderTest[0].attacked=false;
            attacked=false;
        }
        if (message.Equals("Attack2AnimationEnded"))
        {
            AttackColliderTest[1].attacked=false;
        }
    }

}
