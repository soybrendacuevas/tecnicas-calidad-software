using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody2D))]
public class Npc : MonoBehaviour {

    Rigidbody2D _rb2D;
    GameObject _player;
    [SerializeField] float treshHoldDistance = 1f;
    [SerializeField] float speed = 1f;
    Vector2 _direction; 

    void Start() {
        _rb2D = GetComponent<Rigidbody2D>();
        _player = GameObject.Find("Player");
    }

    void Update() {
        if(Vector2.Distance(_player.transform.position, transform.position) < treshHoldDistance){
            Move();
        }
    }

    void Move(){
        _direction = (_player.transform.position - transform.position).normalized;
        _rb2D.linearVelocity = new Vector2(1,0) * _direction * speed;
    }
}
