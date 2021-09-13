using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

4.)Rotirajte kocku za 3 stupnja svaku sekundu:
a) Po X osi
b) po Y osi
c) Po X i Y osi
D) Kada se rotira po X i Y osi, rotira li se i po Z?

--------------------------------------------------------------------------------

d) da!

*/

public class Z_2_4 : MonoBehaviour
{
    const int ROTATE_SPEED = 3;

    public bool rotateOnXAxis;
    public bool rotateOnYAxis;

    public void Update()
    {
        if (rotateOnXAxis)
        {
            transform.Rotate(new Vector3(ROTATE_SPEED * Time.deltaTime, 0, 0));
        }
        if (rotateOnYAxis)
        {
            transform.Rotate(new Vector3(0, ROTATE_SPEED * Time.deltaTime, 0));
        }
    }
}
