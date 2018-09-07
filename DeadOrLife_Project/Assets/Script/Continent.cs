using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cont
{
    public class Continent : MonoBehaviour
    {

        int[] id = { 0, 10, 23, 82, 99 };

        int[] id_Eu = { 0, 12, 24, 39, 50, 58, 61, 64, 66, 73 };

        int[] id_Am = { 0, 44, 61, 66, 94 };

        int[] id_As = { 0, 36, 39, 42, 43, 77, 84, 87, 92, 96, 98 };

        int[] id_Af = { 0, 16, 29, 44, 73, 78, 84, 91 };

        int[] id_Oc = { 0, 66, 87 };

        int[] id_ch = { };

        public string[] Eu = { "France", "Angleterre", "Allemagne", "Italie", "Espagne", "Pays-Bas", "Roumanie", "Grèce", "Pologne", "Russie" };

        public string[] Am = {"USA","Mexique","Canada","Brésil","Argentine"};

        public string[] As = {"Chine","Japon","Viêt Nam","Corée","Inde","Indonésie","Philippines","Pakistan","Bangladesh","Iran","Turquie"};

        public string[] Af = {"Ethiopie","République du Congo","Egypte","Nigéria","Maroc","Algérie","Kenya","Afrique du sud"};

        public string[] Oc = {"Australie","Papouasie-Nouvelle-Guinée","Nouvelle-Zélande"};

        public string[] ch = { };

        public string Rand_Cont() // cherche un continent puis retourne le pays de ce continent
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
                else if (r == 99)
                {
                    res = id.Length-1;
                    break;
                }
            }

            if(res == 0)
            {
                id_ch = id_Eu;
                ch = Eu;
            }
            else if(res == 1)
            {
                id_ch = id_Am;
                ch = Am;
            }
            else if (res == 2)
            {
                id_ch = id_As;
                ch = As;
            }
            else if (res == 3)
            {
                id_ch = id_Af;
                ch = Af;
            }
            else if (res == 4)
            {
                id_ch = id_Oc;
                ch = Oc;
            }

            int s = Random.Range(0,99);
            int taille = id_ch.Length;

            for (int j = 1; j < taille; j++)
            {
                if (r < id_ch[j])
                {
                    res = j - 1;
                    break;
                }
                else if (r > id_ch[taille-1]) //TO DO: Modifié le 99 pour les tableaux
                {
                    res = id_ch.Length-1;
                    break;
                }
            }

            resultat = ch[res];

            return resultat;
        }



    }
}
