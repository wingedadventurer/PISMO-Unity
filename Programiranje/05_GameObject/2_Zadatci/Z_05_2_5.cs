using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
5.) Kada kocka prođe kroz sferu (izlaz) neka se deaktivira skripta
*/

public class Z_05_2_5 : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "SphereTrigger")
        {
            enabled = false;
        }
    }

    // služi samo da se vidi checkbox u inspectoru
    private void Start()
    {
        
    }
}
