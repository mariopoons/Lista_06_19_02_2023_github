using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    public int leftEnd;
    public int rightEnd;

    private void Start()
    {
        while (leftEnd<=rightEnd)// mientras que leftEnd sea menor o igual a rightEnd hazme lo que pida abajo
        {
            if (leftEnd % 5 == 0) // si left end es divisible entre 5, entonces muestrame en consola el numero el cual es divisible entre 5.
                Debug.Log(leftEnd);
        }
        leftEnd++;
    }
}
