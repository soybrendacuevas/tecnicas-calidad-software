using UnityEngine;

public class GameplayTester : MonoBehaviour
{
    public bool enableLogging = true; 
    public Transform playerTransform;


    void Start()
    {
        Debug.Log("Iniciando pruebas...");  
    }

    void Update()
    {
        if (playerTransform.position.y < -10f){
            LogError("Error fuera del mapa");
        }
    }

    void LogError(string message)
    {
        if (enableLogging)
        {
            Debug.Log(message);
        }
    }
}