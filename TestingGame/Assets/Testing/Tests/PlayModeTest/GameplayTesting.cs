using UnityEngine;

public class GameplayTester : MonoBehaviour
{
    public bool enableLogging = true; // Permitir o no el registro de eventos
    private 
    void Start()
    {
        Debug.Log("Iniciando pruebas...");
    }

    void Update()
    {
        //if ()
        // Verificar si el jugador cae por debajo de cierto umbral
        // y mostrar un mensaje en la consola.
    }

    void LogError(string message)
    {
        if (enableLogging)
        {
            // Registrar el mensaje de error en la consola.
        }
    }
}
