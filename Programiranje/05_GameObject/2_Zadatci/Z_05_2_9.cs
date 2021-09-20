using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
9.) Neka se svakih 5 sekundi stvori kocka (prefab) na poziciji 0,(redni broj stvorene kocke), 0
*/

public class Z_05_2_9 : MonoBehaviour
{
    public GameObject cube;

    // public je da pratimo vrijednost
    public float t = 5.0f;
    public int i;

    void Update()
    {
        t -= Time.deltaTime;
        if (t < 0.0f)
        {
            Instantiate(cube, new Vector3(0, i, 0), new Quaternion());
            t += 5.0f;
            i++;
        }
    }
}
