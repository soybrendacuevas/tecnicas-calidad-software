using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    public float _speed = 5.0f; // Arreglo: Se agregan guiones bajos para identificar variables
    public float _jumpForce = 5.0f;
    private float _move;
    private bool isGrounded;
    [SerializeField] private Rigidbody2D RB2D; // Arreglo: se agrega esta linea para obtener desde editor el rigidbody que manejará las físicas. 

    void Update()
    {
        _move = Input.GetAxis("Horizontal"); //Arreglo: Se inicializa la varible "_move" para evitar uso de memoria innecesaria
        transform.position += new Vector3(_move * _speed * Time.deltaTime, 0, 0);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            RB2D.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse); //Arreglo: Se reemplaza la Linea "Get Component" con el Rigidbody que ya obtenemos. 
        }
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
        if (collision.gameObject.CompareTag("Ground")) // Mejora: Se recomienda ocupar mejor un trigger para poder tener un mejor control o mejorar la experiencia del salto en general
        {                                              // debido a que puede existir de una manera más dinamica y ocupar el trigger que está debajo, por ejemplo para detectar diferentes
            isGrounded = false;                        // tipos de suelo u otros features. 
        }
    }

    //public void Jump()
    //{
    //    if (isGrounded)
    //    {
    //        RB2D.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse); //Mejora: Manejar los saltos a través del nuevo Input System de Unity para no tener función que está 
    //                                                                        // llamandosé muchas veces. 
    //    }
    //}

    //public int Move(InputAction.CallbackContext)
    //{
    //    _move = InputAction.CallbackContext;         
    //    transform.position += new Vector3(_move * _speed * Time.deltaTime, 0, 0); // Mejora: Lo mismo que el caso anterior manejarlo a través del input system.
    //}


}
