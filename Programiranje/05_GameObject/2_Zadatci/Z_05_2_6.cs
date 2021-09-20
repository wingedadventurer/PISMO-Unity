using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
6.) Na tipku M neka se uništi game object na sceni
*/

public class Z_05_2_6 : MonoBehaviour
{
    public GameObject gameObjectToDestroy;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && gameObjectToDestroy)
        {
            Destroy(gameObjectToDestroy);
        }
    }
}
