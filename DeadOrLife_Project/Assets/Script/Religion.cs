using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reli
{
    public class Religion : MonoBehaviour
    {
        int[] id = { 0, 31, 54, 70, 85, 92, 96, 98};
        string[] rel = { "Christianisme", "Musulmane", "Athéiste", "Hindouisme", "Bouddhisme", "Juive", "Taoïsme", "Shintoïsme" };

        public string Rand_Reli()
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
                else if (r > 97)
                {
                    res = id.Length-1;
                    break;
                }
            }

            resultat = rel[res];

            return resultat;
        }

    }
}
