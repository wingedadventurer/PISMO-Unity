using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
2) Unesite dvije javne vrijednosti (float i int) ako je njihov zbroj veći od 20 neka se sve osi povećaju za 20,
a ako je njihov zbroj manji ili jednak od 20 neka se objekt po svim osima smanji za zbrojenu vrijednost.
*/

public class Z_4_2 : MonoBehaviour
{
    public float f;
    public int i;

    private void Start()
    {
        if (f + i > 20)
        {
            transform.localScale += Vector3.one * 20;
        }
        else
        {
            transform.localScale -= Vector3.one * (f + i);
        }
    }
}
