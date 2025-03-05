//using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 8f;
    private Rigidbody2D rb;
    Transform cubo;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cubo = GetComponent<Transform>();
    }

    void Update()
    {
       float moveX = Input.GetAxis("Horizontal");
       rb.linearVelocity = new Vector2(moveX * speed, rb.linearVelocity.y);
        
        
        if (Input.GetKeyDown(KeyCode.Space) && cubo.position.y < -2)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        } 

        
    }

    
}
