using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    public Vector3[] positions;

    private void Start()
    {
        StartCoroutine (MoveCube());
    }

    private IEnumerator MoveCube()
    {
        foreach(Vector3 pos in positions) // recorrerá el array que digamos, en este caso, el array Vector3
        {
            transform.position = pos;
            yield return new WaitForSeconds(1f);
        }
    }
}
