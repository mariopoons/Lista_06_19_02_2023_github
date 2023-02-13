using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    private int i = 1;

    private void Start()
    {
        while (i <= 20)
        {
            Debug.Log("Hola, holita, vecinito");
            i++;
        }
    }
}
