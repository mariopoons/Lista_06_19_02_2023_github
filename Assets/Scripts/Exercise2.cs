using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    private int i = 1;

    private void Start()
    {
        while (i <= 20) /* mientras "i" sea menor o igual a 20, poner en consola "Hola, holita, vecinito", 
                           es decir, pondra en consola 20 veces "Hola, holita, vecinito"*/
        {
            Debug.Log("Hola, holita, vecinito");
            i++;
        }
    }
}
