using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
3.) Kada kocka padne na sferu neka se uništi sfera
*/

public class Z_05_2_3 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            Destroy(collision.gameObject);
        }
    }
}
