using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

5.) Scejlajte kocku za:
a) 0.25 po Y osi svaki frame
b) 89 po Z osi pri pokretanju igre
c) Kada se odradio b) zadatak neka debug ispiše kolika je trenutna veličina Z osi

*/

public class Z_2_5 : MonoBehaviour
{
    public bool a, b, c;

    public void Start()
    {
        if (b)
        {
            transform.Rotate(new Vector3(0, 0, 89));
        }
        if (c)
        {
            Debug.Log("trenutna velicina Z osi = " + (transform.rotation.eulerAngles.z));
        }
    }

    public void Update()
    {
        if (a)
        {
            transform.Rotate(new Vector3(0, 0.25f, 0));
        }
    }
}
