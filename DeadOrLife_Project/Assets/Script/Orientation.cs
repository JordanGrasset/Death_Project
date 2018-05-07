using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ori
{
    public class Orientation : MonoBehaviour
    {

        int[] id = { 0, 65, 93 };
        string[] ori = { "Hé", "Ho", "Bi"};

        public string Rand_Ori()
        {
            int res = 0;
            string resultat = "";

            int r = Random.Range(0, 99);

            for (int i = 1; i <= id.Length; i++)
            {
                if (r < id[i])
                {
                    res = i - 1;
                    break;
                }
                else if (r > 92)
                {
                    res = id.Length-1;
                    break;
                }
            }

            resultat = ori[res];

            return resultat;
        }

    }
}
