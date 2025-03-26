//using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public Rigidbody2D rb;
    private bool isGrounded;

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();

        if (rb == null) {
            Debug.LogError("Rigidbody2D no encontrado en el GameObject. Añádelo desde el Inspector.");
        }
    }
    public void Update()
    {
       float moveX = Input.GetAxis("Horizontal");
       rb.linearVelocity = new Vector2(moveX * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isGrounded = false;
        } 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Death"))
        {
            Destroy(this.gameObject);
        }
    }


}
