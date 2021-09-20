using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
4.) Kada kocka padne na sferu neka se ova skripta uništi
*/

public class Z_05_2_4 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            Destroy(this);
        }
    }
}
