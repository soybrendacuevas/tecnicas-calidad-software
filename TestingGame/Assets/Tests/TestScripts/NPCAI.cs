using UnityEngine;
using UnityEngine.AI;

public class NPCAI : MonoBehaviour
{
    private NavMeshAgent agent;  // Componente de navegación
    public Transform target;  // Objetivo del NPC (puede ser el jugador)
    public float detectionRange = 5f;  // Rango de detección

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();  // Obtener el componente NavMeshAgent
    }

    void Update()
    {
        // Si el objetivo no es nulo y está dentro del rango de detección
        if (target != null && Vector3.Distance(transform.position, target.position) < detectionRange)
        {
            agent.SetDestination(target.position); // Moverse hacia el objetivo
        }
    }
}