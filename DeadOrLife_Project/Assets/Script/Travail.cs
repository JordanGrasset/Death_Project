using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tra
{
    public class Travail : MonoBehaviour
    {

        int[] id = { 0, 15, 18, 19, 23, 24, 26, 27, 29, 33, 35, 36, 38, 39, 43, 50, 52, 58, 61, 62, 63, 64, 65, 66, 67, 68, 75, 77, 80, 82, 84, 88, 90, 97, 98, 99 };
        string[] tra = { "Agriculteur", "Jardinier", "Pêcheur", "Travaux public", "Architecte", "Electricien", "Forgeron", "Mécanicien", "Travailleur à la chaine", "Travailleur du cuir", "Menuisier",
            "Maintenance", "Ingénieur", "Manutention", "Conducteur de véhicule", "Artisan", "Secrétaire", "Comptable", "Informaticien", "Chercheur", "Avocat", "Soldat", "Policier", "Pompier", "Banquier",
            "Vendeur", "Boulanger", "Cuisinier", "Coiffeur", "Artiste", "Infirmier", "Médecin", "Enseignant", "Religieux", "Politicien"};

        public string Rand_Tra()
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

            resultat = tra[res];

            return resultat;
        }

    }
}