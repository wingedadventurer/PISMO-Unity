using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
1) Unesite dvije javne vrijednosti. Neka se objekt na sceni uveća po svim osima u početku za zbroj te dvije javne vrijednosti.
*/

public class Z_4_1 : MonoBehaviour
{
    public int a, b;

    private void Start()
    {
        transform.localScale += Vector3.one * (a + b);
    }
}
