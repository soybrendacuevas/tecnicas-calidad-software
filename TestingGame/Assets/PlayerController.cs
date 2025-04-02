using UnityEngine;

public class PlayerController : MonoBehaviour {

    #region Variables

    [Header("Movement")]
    public float speed = 5.0f;
    public LayerMask groundLayer;

    [Header("Jump")]
    public float jumpForce = 5.0f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    private bool isGrounded;

    private Rigidbody2D rb;

    #endregion

    #region private Methods

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded) {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate() {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

    #endregion
}