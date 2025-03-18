using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine;

public class ExamplePlayTest
{
    [UnityTest]
    public IEnumerator MoveObjectTest()
    {
        GameObject obj = new GameObject();
        obj.transform.position = Vector3.zero;
        obj.transform.position += Vector3.forward;

        yield return null; // Esperar un frame

        Assert.AreEqual(Vector3.forward, obj.transform.position);
    }
}
