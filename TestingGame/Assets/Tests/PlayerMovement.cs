//using Unity.VisualScripting; Eliminar libreria que no se usa
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField] public float moveSpeed = 5f; //cambiamos el tipo de protección de las variables y agregamos el "SerializeField" para modificarla desde el editor
    [SerializeField] float jumpForce = 8f; //cambiamos el tipo de protección de las variables y agregamos el "SerializeField" para modificarla desde el editor
    Rigidbody2D rb;
    [SerializeField] GameObject groundCheck;
    bool isGrounded = false;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update() {
        Move();
        Jump();
    }

    void Move() {
        float moveX = Input.GetAxis("Horizontal");
        //rb.linearVelocity = new Vector2(moveX * moveSpeed, rb.linearVelocity.y);
        rb.linearVelocityX = moveX * moveSpeed;
    }

    void Jump() {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            //rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            rb.linearVelocity = Vector2.up * jumpForce;
            isGrounded = false;
        } 
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Ground")){
            isGrounded = true;
        }
    }
    
}
