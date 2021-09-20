using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
2.) Na tipku S uništite ovu skriptu sa objekta
*/

public class Z_05_2_2 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Destroy(this);
        }
    }
}
