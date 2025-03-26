using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f, jumpForce = 8f, moveX;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       moveX = Input.GetAxis("Horizontal");
       rb.linearVelocity = new Vector2(moveX * speed, rb.linearVelocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        } 
    }
}