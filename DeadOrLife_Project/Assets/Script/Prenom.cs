using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pre
{
    public class Prenom : MonoBehaviour
    {

        string[] PM_F = {"Thomas", "Valentin", "Dylan", "Edwin", "Mathieu", "Pierre", "Clément", "Florian", "Thibault"};
        string[] PF_F= { "Marie", "Julie", "Camille", "Léa", "Morgane", "Louise", "Lisa", "Alice", "Emilie" };
        string[] N_F = { "Dubois", "Leroy", "Leroux", "Blanc", "Petit", "Vidal", "Gaillard", "Picard", "Lemaire" };

        string[] PM_C = { "Haoyu", "Haoxuan", "Yuze", "Bowen", "Haoyu", "Rui", "Xin", "Shuo", "Junxi" };
        string[] PF_C = { "Chenxi", "Zihan", "Yuhan", "Yutong", "Han", "Yinuo", "Shiqi", "Jiayi", "Mengyao" };
        string[] N_C = { "Liu", "Chen", "Yang", "Huang", "Zhao", "Wu", "Zhou", "Lin", "Liang" };

        string[] PM_A = { "Peter", "Adam", "James", "Harry", "Jordan", "Nathan", "Scott", "Matt", "Alex" };
        string[] PF_A = { "Emily", "Chloe", "Charlotte", "Jessica", "Lily", "Amber", "Zoe", "Lucy", "Kate" };
        string[] N_A = { "Smith", "Murphy", "Brown", "Roy", "White", "Wilson", "Evans", "Byrne", "Anderson" };

        string[] PM_All = { "Stephan", "Ludwig", "Hermann", "Siegfried", "Gunter", "Mathias", "Heinrich", "Armin", "Karl" };
        string[] PF_All = { "Lili", "Leonore", "Lora", "Katharina", "Susanne", "Minna", "Marlene", "Angelika", "Hedwig" };
        string[] N_All = { "Ackermann", "Bauer", "Becker", "Fischer", "Gärtner", "Hoffmann", "Engel", "Hänzel", "Freimann" };

        string[] PM_R = { "Sergey", "Ivan", "Dmitry", "Max", "Alexander", "Danil", "Sasha", "Igor", "Andrew" };
        string[] PF_R = { "Anna", "Anastasia", "Kate", "Diana", "Helen", "Maria", "Irina", "Masha", "Sofia" };
        string[] N_R = { "Alinovitch", "Leonidov", "Ribinski", "Samarine", "Ukhar", "Vassileff", "Yuri", "Winograd", "Ivan" };

        string[] PM_J = { "Hiroki", "Shinji", "Hiro", "Takumi", "Tatsuya", "Issei", "Masaki", "Ryota", "Ren" };
        string[] PF_J = { "Haruka", "Shiori", "Natsumi", "Ai", "Saki", "Ayumi", "Ayano", "Yuna", "Kaori" };
        string[] N_J = { "Sato", "Watanabe", "Tanaka", "Nakamura", "Shimizu", "Murakami", "Sakamoto", "Aoki", "Abe" };

        string[] PM_Alg = { "Mohamed", "Nazim", "Karim", "Mehdi", "Omar", "Adel", "Youcef", "Walid", "Nassim" };
        string[] PF_Alg = { "Sarah", "Camélia", "Lilia", "Yasmine", "Mira", "Amina", "Sabrina", "Lynda", "Chiraz" };
        string[] N_Alg = { "Mansouri", "Saidi", "Belabed", "Hadji", "Gasmi", "Latreche", "Kara", "Meziani", "Sahli" };

        string[] PM_E = { "David", "Pablo", "Juan", "Manuel", "Jari", "Diego", "Fran", "Antonio", "Adrian" };
        string[] PF_E = { "Marina", "Inès", "Clara", "Elena", "Irene", "Ana", "Patricia", "Silvia", "Laura" };
        string[] N_E = { "Garcia", "Torrès", "Sanchez", "Gomez", "Costa", "Gonzalea", "Sola", "Vidal", "Moreno" };

        string[] PM_N = { "Emmanuel", "Michael", "Victor", "Isaac", "Miracle", "Patrick", "Williams", "Sam", "Kingsley" };
        string[] PF_N = { "Esther", "Rose", "Grace", "Jennifer", "Stella", "Promise", "Mercy", "Blessing", "Abigail" };
        string[] N_N = { "Abba", "Girei", "Udah", "Rasaki", "Tutuola", "Latifu", "Danmusa", "Falae", "Obiajunwa" };

        string[] PM_I = { "Deepak", "Anil", "Neeraj", "Rahul", "Amit", "Rohan", "Ankur", "Manoj", "Yash" };
        string[] PF_I = { "Tanya", "Shivani", "Nikita", "Sanjana", "Vani", "Divya", "Anjali", "Ishita", "Priyanka" };
        string[] N_I = { "", "", "", "", "", "", "", "", "" };

        string[] PM_No = { "Sander", "Marius", "Jonas", "Robin", "Lars", "Sebastian", "Magnus", "Bastian", "Henrik" };
        string[] PF_No = { "Emma", "Frida", "Aurora", "Nora", "Elise", "Ingrid", "Amalie", "Mia", "Thea" };
        string[] N_No = { "Peterssen", "Berg", "Haugen", "Dahl", "Swendsen", "Solberg", "Strand", "Andersen", "Olsen" };

        Cont.Continent cont = new Cont.Continent();
        //TO DO : Trouver des noms pour chaque pays
        public string Rand_PM(string res_pays)
        {
            int r = Random.Range(0, 99);
            string resultat = "";

            for (int j = 0; j < cont.Eu.Length; j++)
            {
                if (res_pays == cont.Eu[j])
                {
                    resultat = PM_F[Random.Range(0, PM_F.Length)];
                    break;
                }
            }

            for (int j = 0; j < cont.Am.Length; j++)
            {
                if (res_pays == cont.Am[j])
                {
                    resultat = PM_A[Random.Range(0, PM_A.Length)];
                    break;
                }
            }

            for (int j = 0; j < cont.As.Length; j++)
            {
                if (res_pays == cont.As[j])
                {
                    resultat = PM_C[Random.Range(0, PM_C.Length)];
                    break;
                }
            }

            for (int j = 0; j < cont.Af.Length; j++)
            {
                if (res_pays == cont.Af[j])
                {
                    resultat = PM_Alg[Random.Range(0, PM_Alg.Length)];
                    break;
                }
            }

            for (int j = 0; j < cont.Oc.Length; j++)
            {
                if (res_pays == cont.Oc[j])
                {
                    resultat = PM_A[Random.Range(0, PM_A.Length)];
                    break;
                }
            }

            return resultat;
        }


        public string Rand_PF(string res_pays)
        {
            int r = Random.Range(0, 99);
            string resultat = "";

            for (int j = 0; j < cont.Eu.Length; j++)
            {
                if (res_pays == cont.Eu[j])
                {
                    resultat = PF_F[Random.Range(0, PF_F.Length)];
                    break;
                }
            }

            for (int j = 0; j < cont.Am.Length; j++)
            {
                if (res_pays == cont.Am[j])
                {
                    resultat = PF_A[Random.Range(0, PF_A.Length)];
                    break;
                }
            }

            for (int j = 0; j < cont.As.Length; j++)
            {
                if (res_pays == cont.As[j])
                {
                    resultat = PF_C[Random.Range(0, PF_C.Length)];
                    break;
                }
            }

            for (int j = 0; j < cont.Af.Length; j++)
            {
                if (res_pays == cont.Af[j])
                {
                    resultat = PF_Alg[Random.Range(0, PF_Alg.Length)];
                    break;
                }
            }

            for (int j = 0; j < cont.Oc.Length; j++)
            {
                if (res_pays == cont.Oc[j])
                {
                    resultat = PF_A[Random.Range(0, PF_A.Length)];
                    break;
                }
            }

            return resultat;
        }


        public string Rand_N(string res_pays)
        {
            int r = Random.Range(0, 99);
            string resultat = "";

            for (int j = 0; j < cont.Eu.Length; j++)
            {
                if (res_pays == cont.Eu[j])
                {
                    resultat = N_F[Random.Range(0, N_F.Length)];
                    break;
                }
            }

            for (int j = 0; j < cont.Am.Length; j++)
            {
                if (res_pays == cont.Am[j])
                {
                    resultat = N_A[Random.Range(0, N_A.Length)];
                    break;
                }
            }

            for (int j = 0; j < cont.As.Length; j++)
            {
                if (res_pays == cont.As[j])
                {
                    resultat = N_C[Random.Range(0, N_C.Length)];
                    break;
                }
            }

            for (int j = 0; j < cont.Af.Length; j++)
            {
                if (res_pays == cont.Af[j])
                {
                    resultat = N_Alg[Random.Range(0, N_Alg.Length)];
                    break;
                }
            }

            for (int j = 0; j < cont.Oc.Length; j++)
            {
                if (res_pays == cont.Oc[j])
                {
                    resultat = N_A[Random.Range(0, N_A.Length)];
                    break;
                }
            }

            return resultat;
        }

    }
}
