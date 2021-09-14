using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
4) Neka skripta učita sve vrijednosti objekta (sve osi scale, sve osi position, sve osi rotation) i potom radi provjeru,
ako je zbroj x y i z (scale posebno, rotation posebno, position posebno) veći od 20 neka se objekt postavi na 0,0,0 sa rotacijama na 0,0,0 i veličinom 1, 1 ,1.
U suprotnom neka se pomakne po svim osima za zbroj (početnih osi pozicije),
poveća po svim osima za zbroj (za zbroj svih scale osi) i rotira po svim osima na 69, 420, 911.
*/

public class Z_4_4 : MonoBehaviour
{
    private void Start()
    {
        float scaleX = transform.localScale.x;
        float scaleY = transform.localScale.y;
        float scaleZ = transform.localScale.z;
        float positionX = transform.position.x;
        float positionY = transform.position.y;
        float positionZ = transform.position.z;
        float rotationX = transform.rotation.eulerAngles.x;
        float rotationY = transform.rotation.eulerAngles.y;
        float rotationZ = transform.rotation.eulerAngles.z;

        float scaleSum = scaleX + scaleY + scaleZ;
        float positionSum = positionX + positionY + positionZ;
        float rotationSum = rotationX + rotationY + rotationZ;

        if (scaleSum > 20 || positionSum > 20 || rotationSum > 20)
        {
            transform.position = Vector3.zero;
            transform.localScale = Vector3.one;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.position += Vector3.one * positionSum;
            transform.localScale += Vector3.one * scaleSum;
            transform.Rotate(69, 420, 911);
        }
    }
}
