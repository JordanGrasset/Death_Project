using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace Perso {
    public class Personnage : MonoBehaviour {

        //Variable de l'age                                             //TO_DO : Mettre l'age
        public int age;

        //Variable d'appel de classe permettant de chercher l'élément pour l'affichage final
        Cont.Continent cont = new Cont.Continent();

        Reli.Religion reli = new Reli.Religion();

        Ori.Orientation ori = new Ori.Orientation();

        Che.Cheveux che = new Che.Cheveux();

        Tra.Travail tra = new Tra.Travail();

        Hand.Handicap hand = new Hand.Handicap();

        Pre.Prenom pre = new Pre.Prenom();
        //

        //Variable Pas encore utiliser ou qui n'as pas encore ete mise en place                     //TO_DO ; Mettre en place ces variable ci_dessous
        public string[] Genre = new string[] { "Masculin", "Feminin" };

       // public string[] Politique = new string[] { "N/A", "Capitaliste", "Communiste", "Socialiste", "Fachisme", "Marxisme", "Anarchiste" };

        public string[] Handicap = new string[] { "Physique", "Mental" };

        public string[] Planete = new string[] { "Pollution", "Population", "Déchet" };

        string Sc = "Science";

        
        //richesse mondiale / seuil de pauvreté
        //peau -> appartenance ethnique
        //auteur Orwell

        //Variable d'appel du gameObject Texte
        public Text Txt1;
        

        //variable pour set le texte pour l'initialisation
        string choice;

        // Use this for initialization
        void Start() {
            //Initialisation du texte dans le gameObject de la scene
            Txt1.text = CreateP(choice);
            
        }

        // Update is called once per frame
        void Update() {
            
        }
        //fonction de creation de description du personnage
        public string CreateP(string choix)
        {


            int r = Random.Range(0, 100);
            string res_cont = cont.Rand_Cont();
            string res_prem = pre.Rand_PM(res_cont);
            string res_pref = pre.Rand_PF(res_cont);
            string res_pren = pre.Rand_N(res_cont);
            string res_reli = reli.Rand_Reli();
            string res_ori = ori.Rand_Ori();
            string res_che = che.Rand_Che(); // TO DO : ajouter en dessous
            string res_tra = tra.Rand_Tra();
            string res_hand = hand.Rand_Hand(); // TO DO : Same

            
            //Random du genre + affichage de la description

            if (r < 51)
            {
                choix = "Nom : " + res_pren + "      " + "Prénom : " + res_pref +
                    "\n \n" + "Pays : " + res_cont + "       " + "Religion : " + res_reli +
                    "\n \n" + "Métier : " + res_tra + "      " + /*"Politique : " + Politique[Random.Range(0, Politique.Length)] +*/
                    "\n \n" + "Genre : " + Genre[1] + "       " + "Orientation : " + res_ori;
            }
            else
            {
                choix = "Nom : " + res_pren+ "      " + "Prénom : " + res_prem +
                    "\n \n" + "Pays : " + res_cont + "       " + "Religion : " + res_reli +
                    "\n \n" + "Métier : " + res_tra + "      " + /*"Politique : " + Politique[Random.Range(0, Politique.Length)] +*/
                    "\n \n" + "Genre : " + Genre[0] + "       " + "Orientation : " + res_ori;
            }

            return choix;
        }

    }
}
