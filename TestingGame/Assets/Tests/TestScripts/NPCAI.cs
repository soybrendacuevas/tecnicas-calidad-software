using UnityEngine;
using UnityEngine.AI;

public class NPCAI : MonoBehaviour
{
    private NavMeshAgent agent;  // Componente de navegaci�n
    public Transform target;  // Objetivo del NPC (puede ser el jugador)
    public float detectionRange = 5f;  // Rango de detecci�n

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();  // Obtener el componente NavMeshAgent
    }

    void Update()
    {
        // Si el objetivo no es nulo y est� dentro del rango de detecci�n
        if (target != null && Vector3.Distance(transform.position, target.position) < detectionRange)
        {
            agent.SetDestination(target.position); // Moverse hacia el objetivo
        }
    }
}