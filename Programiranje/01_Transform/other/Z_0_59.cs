using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

59.) Prvi vozac ima 10 kockica, a drugi ima 13. Kada se oni sudare onaj koji ima manje ukrade drugome jednu kockicu.

--------------------------------------------------------------------------------

int x = 10;
int y = 13;

if(x > y)
{
	y++;
	x--;
}

else if(y > x)
{
	y--;
	x++;
}

*/

public class Z_0_59 : MonoBehaviour
{
	public int x = 10;
	public int y = 13;

    private void Start()
    {
		Debug.Log("na pocetku prvi vozac ima " + x + " kockica a drugi " + y + " kockica.");

		if (x > y)
		{
			y++;
			x--;
		}

		else if (y > x)
		{
			y--;
			x++;
		}

		Debug.Log("nakon sudara prvi vozac sad ima " + x + " kockica a drugi " + y + " kockica.");
	}
}
