using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class BasicPlayerMovement : MonoBehaviour
{

    public float speed = 0.5f;
    public float jumpHeight = 50f;
    private bool isGrounded = true;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(Vector3.right * movement);

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
    }

    void jump()
    {
        rb.AddForce(Vector2.up * jumpHeight);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

}
