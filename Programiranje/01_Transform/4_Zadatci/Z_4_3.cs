using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
3) Unesite jednu javnu vrijednost npr. 15.4f.
Ako je ona manja ili jednaka 100 neka se objekt poveća po x osi za vrijednost "javnaVrijednost".
JavnaVrijednost se povećava za 1 svaki frame dok god je manja ili jednaka 100, kada javna vrijednost bude veća objekt će stati sa povećavanjem,
što znači da se i objekt povećava po svim osima svaki frame za javnaVrijednost.
*/

public class Z_4_3 : MonoBehaviour
{
    public float value;

    private void Start()
    {
        if (value <= 100)
        {
            transform.localScale += Vector3.right * value;
        }
    }

    private void Update()
    {
        if (value <= 100)
        {
            value++;
            transform.localScale += Vector3.one * value;
        }
    }
}
