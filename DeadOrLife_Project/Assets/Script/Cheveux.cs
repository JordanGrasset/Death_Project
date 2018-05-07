using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Che
{
    public class Cheveux : MonoBehaviour
    {

        int[] id = { 0, 28, 55, 70, 90 };
        string[] che = { "Brun", "Châtain", "Noir", "Blond", "Roux"};

        public string Rand_Che()
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
                else if (r > 89)
                {
                    res = id.Length-1;
                    break;
                }
            }

            resultat = che[res];

            return resultat;
        }

    }
}
