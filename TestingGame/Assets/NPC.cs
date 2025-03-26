using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    private NavMeshAgent _Agent;
    private float _Speed;
    public Transform _Target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _Speed = 5;
        _Agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if((_Target.position.x - transform.position.x)< 2f){
            
            MoveTo();
        }
    }

    private void MoveTo(){
        if(_Target.position.x < transform.position.x){
            transform.position += new Vector3(-1,0,0) * _Speed * Time.deltaTime;
        }else{
            transform.position += new Vector3(1,0,0) * _Speed * Time.deltaTime;
        }
    }
}
