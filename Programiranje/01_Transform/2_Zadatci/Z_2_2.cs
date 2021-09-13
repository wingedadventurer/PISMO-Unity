using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

2.) Glavne funkcije/metode MonoBehavioura su i kada se odvijaju:

- Start - pozove se na frame kad se ova skripta enablea, prije poziva ikoje od Update metoda
- Update - poziva se svaki frame ako je skripta enableana
- Awake - poziva se dok se instanca sa ovom skriptom loada
- FixedUpdate - poziva se svaki fiksni frame ako je skripta enableana (physics)
- LateUpdate - kao Update, poziva se svaki frame ako je skripta enableana, ali nakon svih ostalih Update poziva
- OnEnable - pozove se kad se skripta enablea
- OnDisable - pozove se kad se skripta disablea
- OnGUI - pozove se kad se rendera GUI element ili dogodi GUI event (moze se dogoditi vise puta u frameu)



redoslijed poziva:

(initialization)
- Awake
- OnEnable
- Start

(physics)
- Fixed Update

(update)
- Update
- LateUpdate

(GUI rendering)
- OnGUI

(Disable/enable)
- OnDisable

*/

public class Z_2_2 : MonoBehaviour
{

}
