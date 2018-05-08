using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Interface
{
    public class Interf : MonoBehaviour
    {

        public GameObject PanelPerson, Menu, Option, Historique;

        public Text descriptionPersonnage;
        string ch;
        Perso.Personnage perso = new Perso.Personnage();


        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }



        //Montre le panel des personnages
        public void PanelPA()
        {

            PanelPerson.SetActive(true);
            descriptionPersonnage.text = perso.CreateP(ch);
            
        }

        //Ferme le panel personnage
        public void PanelPC()
        {
            PanelPerson.SetActive(false);
            
        }

        public void HistoriqueA()
        {

            Historique.SetActive(true);
        }

        //Ferme le panel personnage
        public void HistoriqueC()
        {
            Historique.SetActive(false);
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
