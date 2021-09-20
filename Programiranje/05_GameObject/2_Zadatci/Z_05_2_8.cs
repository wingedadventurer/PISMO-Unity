using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
8.) Neka se svakih 10 sekundi stvori kocka(prefab) na poziciji 0,0,0
*/

public class Z_05_2_8 : MonoBehaviour
{
    public GameObject cube;

    // public je da pratimo vrijednost
    public float t = 10.0f;

    void Update()
    {
        t -= Time.deltaTime;
        if (t < 0.0f) { 
            Instantiate(cube, Vector3.zero, new Quaternion());
            t += 10.0f;
        }
    }
}
