using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pre
{
    public class Prenom : MonoBehaviour
    {
        //Prenom,nom
        //français
        string[] PM_F = {"Thomas", "Valentin", "Dylan", "Edwin", "Mathieu", "Pierre", "Clément", "Florian", "Thibault"};
        string[] PF_F= { "Marie", "Julie", "Camille", "Léa", "Morgane", "Louise", "Lisa", "Alice", "Emilie" };
        string[] N_F = { "Dubois", "Leroy", "Leroux", "Blanc", "Petit", "Vidal", "Gaillard", "Picard", "Lemaire" };

        //chinois
        string[] PM_C = { "Haoyu", "Haoxuan", "Yuze", "Bowen", "Haoyu", "Rui", "Xin", "Shuo", "Junxi" };
        string[] PF_C = { "Chenxi", "Zihan", "Yuhan", "Yutong", "Han", "Yinuo", "Shiqi", "Jiayi", "Mengyao" };
        string[] N_C = { "Liu", "Chen", "Yang", "Huang", "Zhao", "Wu", "Zhou", "Lin", "Liang" };

        //Anglais
        string[] PM_A = { "Peter", "Adam", "James", "Harry", "Jordan", "Nathan", "Scott", "Matt", "Alex" };
        string[] PF_A = { "Emily", "Chloe", "Charlotte", "Jessica", "Lily", "Amber", "Zoe", "Lucy", "Kate" };
        string[] N_A = { "Smith", "Murphy", "Brown", "Roy", "White", "Wilson", "Evans", "Byrne", "Anderson" };

        //Allemand
        string[] PM_All = { "Stephan", "Ludwig", "Hermann", "Siegfried", "Gunter", "Mathias", "Heinrich", "Armin", "Karl" };
        string[] PF_All = { "Lili", "Leonore", "Lora", "Katharina", "Susanne", "Minna", "Marlene", "Angelika", "Hedwig" };
        string[] N_All = { "Ackermann", "Bauer", "Becker", "Fischer", "Gärtner", "Hoffmann", "Engel", "Hänzel", "Freimann" };

        //Russe
        string[] PM_R = { "Sergey", "Ivan", "Dmitry", "Max", "Alexander", "Danil", "Sasha", "Igor", "Andrew" };
        string[] PF_R = { "Anna", "Anastasia", "Kate", "Diana", "Helen", "Maria", "Irina", "Masha", "Sofia" };
        string[] N_R = { "Alinovitch", "Leonidov", "Ribinski", "Samarine", "Ukhar", "Vassileff", "Yuri", "Winograd", "Ivan" };

        //Japonais
        string[] PM_J = { "Hiroki", "Shinji", "Hiro", "Takumi", "Tatsuya", "Issei", "Masaki", "Ryota", "Ren" };
        string[] PF_J = { "Haruka", "Shiori", "Natsumi", "Ai", "Saki", "Ayumi", "Ayano", "Yuna", "Kaori" };
        string[] N_J = { "Sato", "Watanabe", "Tanaka", "Nakamura", "Shimizu", "Murakami", "Sakamoto", "Aoki", "Abe" };

        //Algerien
        string[] PM_Alg = { "Mohamed", "Nazim", "Karim", "Mehdi", "Omar", "Adel", "Youcef", "Walid", "Nassim" };
        string[] PF_Alg = { "Sarah", "Camélia", "Lilia", "Yasmine", "Mira", "Amina", "Sabrina", "Lynda", "Chiraz" };
        string[] N_Alg = { "Mansouri", "Saidi", "Belabed", "Hadji", "Gasmi", "Latreche", "Kara", "Meziani", "Sahli" };

        //Espagnol
        string[] PM_E = { "David", "Pablo", "Juan", "Manuel", "Jari", "Diego", "Fran", "Antonio", "Adrian" };
        string[] PF_E = { "Marina", "Inès", "Clara", "Elena", "Irene", "Ana", "Patricia", "Silvia", "Laura" };
        string[] N_E = { "Garcia", "Torrès", "Sanchez", "Gomez", "Costa", "Gonzalea", "Sola", "Vidal", "Moreno" };

        //Afrique du sud
        string[] PM_N = { "Emmanuel", "Michael", "Victor", "Isaac", "Miracle", "Patrick", "Williams", "Sam", "Kingsley" };
        string[] PF_N = { "Esther", "Rose", "Grace", "Jennifer", "Stella", "Promise", "Mercy", "Blessing", "Abigail" };
        string[] N_N = { "Abba", "Girei", "Udah", "Rasaki", "Tutuola", "Latifu", "Danmusa", "Falae", "Obiajunwa" };

        //Indien
        string[] PM_I = { "Deepak", "Anil", "Neeraj", "Rahul", "Amit", "Rohan", "Ankur", "Manoj", "Yash" };
        string[] PF_I = { "Tanya", "Shivani", "Nikita", "Sanjana", "Vani", "Divya", "Anjali", "Ishita", "Priyanka" };
        string[] N_I = { "", "", "", "", "", "", "", "", "" };

        //Norvege
        string[] PM_No = { "Sander", "Marius", "Jonas", "Robin", "Lars", "Sebastian", "Magnus", "Bastian", "Henrik" };
        string[] PF_No = { "Emma", "Frida", "Aurora", "Nora", "Elise", "Ingrid", "Amalie", "Mia", "Thea" };
        string[] N_No = { "Peterssen", "Berg", "Haugen", "Dahl", "Swendsen", "Solberg", "Strand", "Andersen", "Olsen" };



        //tableau de tout les pays rangés par language
        public string[] Continent_Recup = { "France", "Canada",/* <= français*/
            "Angleterre","USA",  "Australie",  "Nouvelle-Zélande","Philippines" /* <= Anglais*/,
            "Allemagne", "Pays-Bas", /* <= Allemand*/
            "Italie", "Espagne",  "Brésil", "Argentine", "Mexique",/* <= Espagnol*/
            "Roumanie", "Grèce","Pologne", "Russie", /* <= Russe*/
            "Chine",  "Viêt Nam", /* <= Chinois*/
            "Japon", "Corée", /* <= Japonais*/
            "Inde", "Indonésie",/* <= Indien*/
            "Algérie", "Maroc", "Pakistan", "Bangladesh", "Iran", "Turquie", /* <= Algerien*/
            "Ethiopie", "République du Congo", "Egypte", "Nigéria",  "Kenya", "Afrique du sud", "Papouasie-Nouvelle-Guinée" }; /* <= Afrique du Sud*/




        Cont.Continent cont = new Cont.Continent();
        //TO DO : Trouver des noms pour chaque pays
        public string Rand_PM(string res_pays)
        {
           // int r = Random.Range(0, 99);
            string resultat = "";

            for (int j = 0; j < Continent_Recup.Length; j++)
            {
                if (res_pays == Continent_Recup[j])
                {
                    switch (j)
                    {
                        case 0:
                        case 1:
                            resultat = PM_F[Random.Range(0, PM_F.Length)];
                            break;
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                            resultat = PM_A[Random.Range(0, PM_A.Length)];
                            break;
                        case 7:
                        case 8:
                            resultat = PM_All[Random.Range(0, PM_All.Length)];
                            break;
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                            resultat = PM_E[Random.Range(0, PM_E.Length)];
                            break;
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                            resultat = PM_R[Random.Range(0, PM_R.Length)];
                            break;
                        case 18:
                        case 19:
                            resultat = PM_C[Random.Range(0, PM_C.Length)];
                            break;
                        case 20:
                        case 21:
                            resultat = PM_J[Random.Range(0, PM_J.Length)];
                            break;
                        case 22:
                        case 23:
                            resultat = PM_I[Random.Range(0, PM_I.Length)];
                            break;
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                            resultat = PM_Alg[Random.Range(0, PM_Alg.Length)];
                            break;
                        case 30:
                        case 31:
                        case 32:
                        case 33:
                        case 34:
                        case 35:
                        case 36:
                            resultat = PM_N[Random.Range(0, PM_N.Length)];
                            break;
                        default:
                            print("Error j");
                            break;

                    }              
                }
            }

            return resultat;
        }


        public string Rand_PF(string res_pays)
        {
            int r = Random.Range(0, 99);
            string resultat = "";

            for (int j = 0; j < Continent_Recup.Length; j++)
            {
                if (res_pays == Continent_Recup[j])
                {
                    switch (j)
                    {
                        case 0:
                        case 1:
                            resultat = PF_F[Random.Range(0, PF_F.Length)];
                            break;
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                            resultat = PF_A[Random.Range(0, PF_A.Length)];
                            break;
                        case 7:
                        case 8:
                            resultat = PF_All[Random.Range(0, PF_All.Length)];
                            break;
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                            resultat = PF_E[Random.Range(0, PF_E.Length)];
                            break;
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                            resultat = PF_R[Random.Range(0, PF_R.Length)];
                            break;
                        case 18:
                        case 19:
                            resultat = PF_C[Random.Range(0, PF_C.Length)];
                            break;
                        case 20:
                        case 21:
                            resultat = PF_J[Random.Range(0, PF_J.Length)];
                            break;
                        case 22:
                        case 23:
                            resultat = PF_I[Random.Range(0, PF_I.Length)];
                            break;
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                            resultat = PF_Alg[Random.Range(0, PF_Alg.Length)];
                            break;
                        case 30:
                        case 31:
                        case 32:
                        case 33:
                        case 34:
                        case 35:
                        case 36:
                            resultat = PF_N[Random.Range(0, PF_N.Length)];
                            break;
                        default:
                            print("Error j");
                            break;

                    }
                }
            }

            return resultat;
        }


        public string Rand_N(string res_pays)
        {
            int r = Random.Range(0, 99);
            string resultat = "";

            for (int j = 0; j < Continent_Recup.Length; j++)
            {
                if (res_pays == Continent_Recup[j])
                {
                    switch (j)
                    {
                        case 0:
                        case 1:
                            resultat = N_F[Random.Range(0, N_F.Length)];
                            break;
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                            resultat = N_A[Random.Range(0, N_A.Length)];
                            break;
                        case 7:
                        case 8:
                            resultat = N_All[Random.Range(0, N_All.Length)];
                            break;
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                            resultat = N_E[Random.Range(0, N_E.Length)];
                            break;
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                            resultat = N_R[Random.Range(0, N_R.Length)];
                            break;
                        case 18:
                        case 19:
                            resultat = N_C[Random.Range(0, N_C.Length)];
                            break;
                        case 20:
                        case 21:
                            resultat = N_J[Random.Range(0, N_J.Length)];
                            break;
                        case 22:
                        case 23:
                            resultat = N_I[Random.Range(0, N_I.Length)];
                            break;
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                            resultat = N_Alg[Random.Range(0, N_Alg.Length)];
                            break;
                        case 30:
                        case 31:
                        case 32:
                        case 33:
                        case 34:
                        case 35:
                        case 36:
                            resultat = N_N[Random.Range(0, N_N.Length)];
                            break;
                        default:
                            print("Error j");
                            break;

                    }
                }
            }

            return resultat;
        }

    }
}
