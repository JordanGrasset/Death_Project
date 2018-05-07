using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pigme
{
    public class Pigmentation : MonoBehaviour
    {

        int[] id = { 0, 5, 20, 45, 70, 90 };
        

        public int Rand_Pigme()
        {
            int res = 0;
            

            int r = Random.Range(0, 99);

            for (int i = 1; i <= id.Length; i++)
            {
                if (r < id[i])
                {
                    res = i - 1;
                    break;
                }
                else if (r == 99)
                {
                    res = id.Length;
                    break;
                }
            }

            

            return res;
        }

    }
}
