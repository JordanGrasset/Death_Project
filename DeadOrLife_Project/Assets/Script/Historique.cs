using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Histoire
{
    public class Historique : MonoBehaviour
    {

        //Tableau des noms des Personnalités célèbres.
        string[] PersonneH = {"Azurduy Juana", "Zulu Chaka", "Babbage Charles", "José de Sucre Antonio", "Victor Hugo", "Parkes Henry", "Marx Karl", "Pasteur Louis", "Darwin Charles",
        "Pie X", "Emile Zola", "Friedrich Nietzsche", "Adler Victor" , "Nikola Tesla", "Jean Jaurès", "Ford Henry", "Curie Marie", "Mohandas Gandhi", "Lénine Vladimir", "Staline Joseph",
        "Einstein Albert", "Hitler Adolf", "De Gaulle Charles","Mâ Ananda Moyî", "Howard Aiken", "Xiaoping Deng", "Turing Alan", "Chinmayananda", "Mandela Nelson", "Castro Fidel",
        "Luther King Martin", "Desmond Tutu", "Tenzin Gyatso", "Hawking Stephen", "Aung San Suu Kyi", "Biko Steve", "Gates Bill", "Vladimir Putine",
        "Barack Obama", "Berners-Lee Tim", "Hongzhi Li", "Page Larry", "Myousafzai Malala", "Jong-un Kim", "Musk Elon" };

        //Tableau des noms des Personnages célèbre.
        string[] PersonneF = {"Twedt Katharine", "Cunha Rafael", "Kiso Teru", "Forwood Max", "Davignon Charline", "Aliyeva Antonina", "Naumann Stefanie", "Quezada Astor",
        "Su Liang", "Wisaal Mona", "Kemp Daisy", "Farmer Alexandra", "Fuentes Judas", "Duval Juliette", "Marcelo Sofia", "Bodrov Athanasius", "Nam Luu Quang", "Santos Vitor",
        "Ganga Shakya", "Yeonhui Yun", "Athanasiadis Varsamos", "Börner Siegried", "Soria Agustin", "Drouin Claire", "Marjoren Janna", "Kobayashi Taichi", "Andreevich Andreev",
        "Kanyesigye Mariane", "Lailasari Kezia", "Gorska Klara", "Lindberg Fredrika", "Stiedemann Kevin", "De Villiers Charmaine", "Sun Yuzhen", "Collard Alexandre", "Baciu Liviu",
        "Mendoza Ana", "Öztonga Bora", "Schmeler Winston", "Adams Francesca", "Garnier Sylvie", "Kaname Akemi", "Greco Giorgio", "Hermann Bryan", "Bilodeau Honorée"/*, "Georgiou Llia"*/  }; //Si personne célèbre 2017

        //Tableau des descriptions rapide des personnalités célèbres.
        string[] DescriptionH = { "est une révolutionnaire sud-américaine, active dans la révolution  de la région du “Alto Peru” ou haut Pérou, actuelle Bolivie.", "Bonjour", "x" };

        //Tableau des descriptions rapide des personnages célèbres.
        string[] DescriptionF = { "est une chercheuse en physique sur la théorie des cordes", "coucou", " " };

        //Variable d'appel de GameObject Texte,Image et Sprite
        public Text txtH;
        public Text txtF;
        //public Image imgH;
        //public Image imgF;
        public Sprite[] spH;
        public Sprite[] spF;

        //public GameObject ImageHHistorique;
        
        //Compteur
        public int i = 0;

        // Use this for initialization
        void Start()
        {
            //initialisation du compteur
            //i = 0;
            //ImageHHistorique.GetComponent<Image>().sprite = spH[i];
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        //Fonction de recherche du nom de la personnalité
        public string Choix_HHistorique(string choix_HHisto)
        {
            choix_HHisto= PersonneH[i];


            
            
            //imgH.sprite = spH[j];

            //retourne le nom
            return choix_HHisto;
        }

        public string Desc_HHistorique(string descH)
        {
            descH = DescriptionH[i];

            return descH;
        }

       public Sprite Img_HHistorique(Sprite imgH)
        {
            
            imgH = spH[i];                      // TO DO : erreur la reference de l'objet est null / il n'arrive pas a recuperer le sprite dans le PC
            Debug.Log(imgH.name);           
            //imgH = spH[i];
            return imgH;
        }

        //Fonction de recherche du nom du personnage
        public string Choix_FHistorique(string choix_FHisto)
        {
            choix_FHisto = PersonneF[i];
                                                                     //TO_DO : Trouver une solution a l'erreur de setting de la reference
            //imgF.sprite = spF[j];
            
            //retourne le nom
            return choix_FHisto;
        }

        public string Desc_FHistorique(string descF)
        {
            descF = DescriptionF[i];
            //Incremente l'ancre des tableaux.
            i++;

            return descF;
        }
    }
}
