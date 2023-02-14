using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{

    public int n = 10;
    private void Start()
    {
        for (int i = n; i >= 0; i -=1) /* mientras "i" sea mayor o igual a 0, restale 1 a "i", estoy hara que haga una cuentra atras. */
        {
            Debug.Log(i);
        }
    }
}
