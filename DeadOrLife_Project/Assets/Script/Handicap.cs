using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hand
{
    public class Handicap : MonoBehaviour
    {

        int[] id = { 0, 85};
        string[] hand = { "N/A", "Handicap"};

        public string Rand_Hand()
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
                else if (r > 84)
                {
                    res = id.Length - 1;
                    break;
                }
            }

            resultat = hand[res];

            return resultat;
        }

    }
}
