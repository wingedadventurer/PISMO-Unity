using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
7.) U startu neka se stvori na sceni na poziciji 0,0,0 objekt kocke koji je spremljen prije toga kao prefab
*/

public class Z_05_2_7 : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        Instantiate(cube, Vector3.zero, new Quaternion());
    }
}
