using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{

    public int n = 10;
    private void Start()
    {
        for (int i = n; i >= 0; i -=1)
        {
            Debug.Log(i);
        }
    }
}
