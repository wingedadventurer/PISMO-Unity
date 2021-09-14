using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

10)
Napravite skriptu gdje se kocka povećava ili smanjuje (do maksimalno 10 i minimalno 0.1) po sve 3 osi i rotira po sve 3 osi uz javne varijable.
Opis: Efekt kao da pulsira do 10 i nazad do 0.1 pa opet do 10 pa opet do 0.1 itd.

*/
public class Z_1_10 : MonoBehaviour
{

    public float pulseSpeed;
    public float rotateSpeed;

    float scaleValue = 0.1f;

    void Update()
    {
        // pulsiranje
        scaleValue += pulseSpeed * Time.deltaTime;
        if (scaleValue > 10)
        {
            scaleValue = 10;
            pulseSpeed *= -1;
        }
        else if (scaleValue < 0.1f)
        {
            scaleValue = 0.1f;
            pulseSpeed *= -1;
        }
        transform.localScale = Vector3.one * scaleValue;

        // rotacija
        transform.Rotate(Vector3.one * rotateSpeed * Time.deltaTime);
    }
}
