using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interf : MonoBehaviour {

    public GameObject PanelPerson, Menu, Option;

    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
    
    //Montre le panel des personnages
    public void PanelPA()
    {
        
        PanelPerson.SetActive(true); 
    }

    //Ferme le panel personnage
    public void PanelPC()
    {
        PanelPerson.SetActive(false);
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
