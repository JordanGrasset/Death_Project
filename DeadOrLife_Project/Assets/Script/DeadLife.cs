using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeadLife : MonoBehaviour {
    public GameObject panelPerso;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    //fonction du bouton death
    public void DLChoice()
    {

        PanelPC();

    }

    public void PanelPC()
    {
        panelPerso.SetActive(false);
    }


}
