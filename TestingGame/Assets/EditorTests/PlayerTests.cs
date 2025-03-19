using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.Collections;

public class PlayerTests 
{
    private GameObject player;
    private PlayerMovement movement;
    
    [SetUp] // Se ejecuta antes de cada prueba
    public void SetUp()
    {
        player = new GameObject();
        movement = player.AddComponent<PlayerMovement>();
        player.AddComponent<Rigidbody2D>();
    }

    // [TearDown] // Se ejecuta después de cada prueba para limpiar
    // public void TearDown()
    // {
    //     Object.Destroy(player);
    // }

    [Test]
    public IEnumerator PlayerMovesRight()
    {
        // Configuración inicial
        float initialX = player.transform.position.x;

        // Simular un frame de juego
        movement.moveSpeed = 5f;
        movement.GetReferences();
        movement.Update();
        
        yield return new WaitForSeconds(1f);
        
        // Verificar si la posición cambió
        Assert.Greater(player.transform.position.x, initialX, "El jugador no se movió a la derecha.");
    }

    [UnityTest]
    public IEnumerator PlayerMovesOverTime()
    {
        float initialX = player.transform.position.x;
        movement.moveSpeed = 2f;
        movement.GetReferences();
        movement.Update();
        // Esperar varios frames en Unity
        yield return new WaitForSeconds(1f);

        // Verificar si la posición cambió tras 1 segundo
        Assert.Greater(player.transform.position.x, initialX, "El jugador no avanzó en el tiempo.");
    }
}
