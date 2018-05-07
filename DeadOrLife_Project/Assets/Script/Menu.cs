using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject option,charger,exitt;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Continue()
    {
        SceneManager.LoadScene("Game");
    }

    public void ChargA()
    {
        charger.SetActive(true);
    }

    public void ChargC()
    {
        charger.SetActive(false);
    }

    public void OptA()
    {
        option.SetActive(true);
    }

    public void OptC()
    {
        option.SetActive(false);
    }

    public void PQuittA()
    {
        exitt.SetActive(true);
    }

    public void PQuittC()
    {
        exitt.SetActive(false);
    }

    public void Quitt()
    {
        Application.Quit();
    }

}
