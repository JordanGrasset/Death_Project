﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace Perso {
    public class Personnage : MonoBehaviour {

        //Tableau d'initialisation des variables
        public int age;

        Cont.Continent cont = new Cont.Continent();

        Reli.Religion reli = new Reli.Religion();

        Ori.Orientation ori = new Ori.Orientation();

        Che.Cheveux che = new Che.Cheveux();

        Tra.Travail tra = new Tra.Travail();

        Hand.Handicap hand = new Hand.Handicap();

        Pre.Prenom pre = new Pre.Prenom();

        public string[] Genre = new string[] { "Masculin", "Feminin" };

       // public string[] Politique = new string[] { "N/A", "Capitaliste", "Communiste", "Socialiste", "Fachisme", "Marxisme", "Anarchiste" };

        public string[] Handicap = new string[] { "Physique", "Mental" };

        public string[] Planete = new string[] { "Pollution", "Population", "Déchet" };

        string Sc = "Science";
        
        //richesse mondiale / seuil de pauvreté
        //peau -> appartenance ethnique
        //auteur Orwell

        public Text Txt1;
        public Text Txt2;

        int i = 0;

        // Use this for initialization
        void Start() {
            CreateP();
            i = 1;
        }



        // Update is called once per frame
        void Update() {
            
            if (i < 3)
            {
                CreateP();
                i++;
            }
            else
            {
                i = 0;
            }
        }
        //fonction de creation de description du personnage
        public void CreateP()
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

            

            if (r < 51)
            {
                Txt1.text = "Nom : " + res_pren + "      " + "Prénom : " + res_pref +
                    "\n \n" + "Pays : " + res_cont + "       " + "Religion : " + res_reli +
                    "\n \n" + "Métier : " + res_tra + "      " + /*"Politique : " + Politique[Random.Range(0, Politique.Length)] +*/
                    "\n \n" + "Genre : " + Genre[1] + "       " + "Orientation : " + res_ori;
            }
            else
            {
                Txt2.text = "Nom : " + res_pren+ "      " + "Prénom : " + res_prem +
                    "\n \n" + "Pays : " + res_cont + "       " + "Religion : " + res_reli +
                    "\n \n" + "Métier : " + res_tra + "      " + /*"Politique : " + Politique[Random.Range(0, Politique.Length)] +*/
                    "\n \n" + "Genre : " + Genre[0] + "       " + "Orientation : " + res_ori;
            }
        }
    }
}
