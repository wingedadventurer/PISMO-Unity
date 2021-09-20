using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
10.) Svakih 5 sekudni neka se u debug.logu ispiše "ja sam magarac"
*/

public class Z_05_2_10 : MonoBehaviour
{
    // public je da pratimo vrijednost
    public float t = 5.0f;

    void Update()
    {
        t -= Time.deltaTime;
        if (t < 0.0f)
        {
            Debug.Log("ja sam magarac");
            t += 5.0f;
        }
    }
}
