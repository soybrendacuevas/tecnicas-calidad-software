using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Enemy : MonoBehaviour
{
    //public NavMeshAgent _navMeshAgent;
    public Transform _player;
    public float _distanceToPlayer;
    private bool _playerInRange;
    public float _enemySpeed = 0.1f;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //_navMeshAgent.SetDestination(_player.position);
        //_navMeshAgent.Move(_player.position);

        _distanceToPlayer = Vector3.Distance(_player.transform.position, transform.position);
        if (_distanceToPlayer > 1f)
        {
        transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _enemySpeed);
        }


    }
}
