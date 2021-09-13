using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

6.) Napravite skriptu da se kocka i sfera povećavaju i smanjuju za 3 do maksimalno 25 i minimalno 1 po sve 3 osi.
Neka se kocka stalno rotira po javnim vrijednostima po sekundi, kada se kocka smanjuje smjer rotacije se promjeni.

*/

public class Z_2_6 : MonoBehaviour
{
    public bool isCube;

    public float cubeRotationSpeedX;
    public float cubeRotationSpeedY;
    public float cubeRotationSpeedZ;

    bool isGrowing = true;
    float scaleValue = 1;

    void Update()
    {
        if (isGrowing)
        {
            scaleValue += 3 * Time.deltaTime;
            if (scaleValue >= 25)
            {
                isGrowing = false;
                scaleValue = 25;
            }
        }
        else
        {
            scaleValue -= 3 * Time.deltaTime;
            if (scaleValue <= 1)
            {
                isGrowing = true;
                scaleValue = 1;
            }
        }
        transform.localScale = Vector3.one * scaleValue;

        if (isCube)
        {
            if (isGrowing)
            {
                transform.Rotate(new Vector3(cubeRotationSpeedX, cubeRotationSpeedY, cubeRotationSpeedZ) * Time.deltaTime);
            }
            else
            {
                transform.Rotate(new Vector3(-cubeRotationSpeedX, -cubeRotationSpeedY, -cubeRotationSpeedZ) * Time.deltaTime);
            }
        }
    }
}
