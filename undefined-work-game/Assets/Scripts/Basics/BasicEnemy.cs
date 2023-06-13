using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.NavigationMoveEvent;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class BasicEnemy : MonoBehaviour
{
    public float speed = 2f;
    public Direction facingDirection = Direction.Right;
    private bool isGrounded = false;
    private Rigidbody2D rb;
    private Transform groundCheck;
    private float groundCheckRadius = 0.2f;
    private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        groundCheck = transform.Find("GroundCheck");
        groundLayer = LayerMask.GetMask("Ground");
    }

    private void FixedUpdate()
    {
        // Check if the enemy is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // Move the enemy
        if (facingDirection == Direction.Right)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
    }

    void Update()
    {
        if (!isGrounded)
        {
            ChangeDirection();
        }
    }

    void ChangeDirection()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        facingDirection = (facingDirection == Direction.Right) ? Direction.Left : Direction.Right;
    }
}
