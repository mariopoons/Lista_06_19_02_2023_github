using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    private void Start()
    {
        for (int i = 100; i >= 0; i=-2) /* esto hará que haya una cuenta atra desde 100, pero restara 2 cada vez.*/
        {
            Debug.Log(i);
        }
    }
}
