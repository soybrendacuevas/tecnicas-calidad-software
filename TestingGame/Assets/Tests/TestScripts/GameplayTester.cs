using UnityEngine;

public  class GameplayTester : MonoBehaviour
{
    public bool enableLogging = true; // Permitir o no el registro de eventos

    [SerializeField] private Transform player;
    [SerializeField] private float fallThreshold = -10f;
    [SerializeField] private bool logErrors;

    void Start()
    {
        Debug.Log("Iniciando pruebas...");
    }

    void Update()
    {
        // Verificar si el jugador cae por debajo de cierto umbral
        // y mostrar un mensaje en la consola.
        if (player.position.y < fallThreshold)
        {
            if (logErrors)
            {
                Debug.Log("¡Player Fall!");
            }
            player.position = Vector3.zero;
        }
    }

    void LogError(string message)
    {
        if (enableLogging)
        {
            // Registrar el mensaje de error en la consola.
        }
    }
}
