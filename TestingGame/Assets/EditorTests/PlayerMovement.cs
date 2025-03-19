//using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 8f;
    public float moveSpeed = 0f;
    [SerializeField] private Rigidbody2D rb;

    void Start(){
        GetReferences();
    }
    
    public void GetReferences()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
       float moveX = Input.GetAxis("Horizontal");
       rb.linearVelocity = new Vector2(1 * speed, rb.linearVelocity.x);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        } 
    }


}
