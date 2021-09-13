using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

3.) Napišite skriptu koja će imati Debug.Log() na:
a) Awake
b) Start
c) Update

*/

public class Z_2_3 : MonoBehaviour
{
    public void Awake()
    {
        //Debug.Log("Awake!");
    }

    public void Start()
    {
        Debug.Log("Start!");
    }

    public void Update()
    {
        Debug.Log("Update!");
    }
}
