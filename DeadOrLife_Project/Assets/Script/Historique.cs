using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Historique : MonoBehaviour {

    //Tableau des noms des Personnalités célèbre.
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

    string[] DescriptionH = { "est une révolutionnaire sud-américaine, active dans la révolution  de la région du “Alto Peru” ou haut Pérou, actuelle Bolivie." };

    string[] DescriptionF = { "est une chercheuse en physique sur la théorie des cordes" };

    public Text txtH;
    public Text txtF;
    public Image imgH;
    public Image imgF;
    public Sprite[] spH;
    public Sprite[] spF;
    public Text descH;
    public Text descF;

    public int i;

    Interface.Interf interf = new Interface.Interf();

    


	// Use this for initialization
	void Start () {

        i = 0;
        txtH.text = PersonneH[i];
        txtF.text = PersonneF[i];

        imgH.sprite = spH[i];
        imgF.sprite = spF[i];

        descH.text = DescriptionH[i];
        descF.text = DescriptionF[i];
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Choix_Historique()
    {
        interf.HistoriqueC();

    }
}
