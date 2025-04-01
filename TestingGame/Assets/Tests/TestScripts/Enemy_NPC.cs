using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class Enemy_NPC : MonoBehaviour
{
    public float speedNPC;
    public float distanceDetection = 1f;
    public Rigidbody2D rb;

    public Transform player;
    public bool _hadFollow = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = player.position - transform.position;

        if (direccion.magnitude > distanceDetection && _hadFollow)
        {
            transform.Translate(direccion.normalized * speedNPC * Time.deltaTime, Space.World);
        }
    }

    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.gameObject.CompareTag("Player"))
        {

            player = p_collision.transform;
            _hadFollow = true;
            //Debug.Log(p_collision.gameObject.name);
            //_navMeshAgent.destination = p_collision.transform.position;
        }
    }

    private void OnTriggerExit2D(Collider2D p_collision)
    {
        if (p_collision.gameObject.CompareTag("Player"))
        {

            _hadFollow = false;
            //Debug.Log(p_collision.gameObject.name);
            //_navMeshAgent.destination = p_collision.transform.position;
        }
    }

}