zusing NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.Collections;

public class PlayerTests
{
    private GameObject player;
    private PlayerMovement movement;

    //[SetUp] // Se ejecuta antes de cada prueba
    public void SetUp()
    {
        player = new GameObject();
        movement = player.AddComponent<PlayerMovement>();
    }

    //[Test]
    public void PlayerMovesRight()
    {
        movement.moveSpeed = 5f;
        movement.Update();
        movement.AreEqual(5f, movement.moveSpeed);
    }

    //[UnityTest] // Prueba en el entorno de Unity
    public IEnumerator PlayerMovesOverTime()
    {
        float initialX = player.transform.position.x;
        movement.moveSpeed = 2f;

        yield return new WaitForSeconds(1f); // Simula un segundo en el juego

        movement.Greater(player.transform.position.x, initialX);
    }
}