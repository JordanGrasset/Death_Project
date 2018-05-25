using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Interface
{
    public class Interf : MonoBehaviour
    {
        //Variable d'appel des gameObject
        public GameObject PanelPerson, Menu, Option, Histori, Next_B, ImageHHistorique;
        public Text descriptionPersonnage, nHHistorique, nFHistorique, date, descHHisto, descFHisto;
        //public Image imageH;

        //Variable de recuperation dans d'autre classe
        string ch;
        string ch_Histo;
        string desc_H;
        string desc_F;
        Sprite img_H;
        
        

        //Variable d'appel de classe
        Histoire.Historique histoire = new Histoire.Historique();
        Perso.Personnage perso = new Perso.Personnage();

        //Compteur pour la boucle de jeu et la date
        int compteur_Perso = 0;
        int compteur_Histo = 0;
        int dt = 1787;
        


        // Use this for initialization
        void Start()
        {
            
            date.text = dt.ToString();
        }

        // Update is called once per frame
        void Update()
        {
            date.text = dt.ToString();
            
            if(dt == 2017)
            {
                dt = 9999; // Fin de partie
            }
        }



        //Montre le panel des personnages
        public void PanelPA()
        {
            //Active le panel
            PanelPerson.SetActive(true);

            //Set le text du panel
            descriptionPersonnage.text = perso.CreateP(ch);
            
        }

        //Ferme le panel personnage
        public void PanelPC()
        {
            //active le panel
            PanelPerson.SetActive(false);

            //incremente le compteur
            compteur_Perso++;
            dt++;
            //Verifie le compteur pour ouvrir le panel historique au bout de 3 boucle
            if(compteur_Perso > 2)
            {
                HistoriqueA();
                Next_B.SetActive(false);

            }
            
        }
        //Montre le panel Historique
        public void HistoriqueA()
        {
            //set les textes du panel historique puis l'active.
            nHHistorique.text = histoire.Choix_HHistorique(ch_Histo);
            nFHistorique.text = histoire.Choix_FHistorique(ch_Histo);
            descHHisto.text = histoire.Desc_HHistorique(desc_H);
            descFHisto.text = histoire.Desc_FHistorique(desc_F);

            //ImageHHistorique.GetComponent<Image>().sprite = histoire.Img_HHistorique(img_H);  // TO DO : appel de la fonction pour le changement d'image
            
            //imageH.sprite = histoire.Img_HHistorique(img_H);
            Histori.SetActive(true);
        }

        //Ferme le panel Historique
        public void HistoriqueC()
        {
            //desactive le panel historique
            Histori.SetActive(false);
            
            //reset le compteur apres les 3 boucles puis reactive le bouton du panel personnage
            compteur_Perso = 0;
            dt++;
            Next_B.SetActive(true);
            

        }

        //Ouve le panel menu
        public void MenuA()
        {
            Menu.SetActive(true);
        }

        //retour sur l'interface
        public void Continue()
        {
            Menu.SetActive(false);
        }

        //ouvre le panel option
        public void Opt()
        {
            Option.SetActive(true);
        }

        //Retour sur le menu
        public void OMenu()
        {
            SceneManager.LoadScene("Menu");
        }

        //quitte l'application
        public void Quitt()
        {
            Application.Quit();
        }
    }
}
