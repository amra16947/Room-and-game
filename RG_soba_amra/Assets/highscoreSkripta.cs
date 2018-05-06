using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscoreSkripta : MonoBehaviour {

    public static List<string> highscore_igraci;
    public static List<int> highscore_bodovi;
    public string player = "";
    public int bodovi1 = 0;
    public static bool pocetniReset = false;
    public Text b1;
    public Text b2;
    public Text b3;
    public Text b4;
    public Text b5;
    public Text i1;
    public Text i2;
    public Text i3;
    public Text i4;
    public Text i5;


    // Use this for initialization
    void Start () {
        b1 = b1.GetComponent<Text>();
        b2 = b2.GetComponent<Text>();
        b3 = b3.GetComponent<Text>();
        b4 = b4.GetComponent<Text>();
        b5 = b5.GetComponent<Text>();
        i1 = i1.GetComponent<Text>();
        i2 = i2.GetComponent<Text>();
        i3 = i3.GetComponent<Text>();
        i4 = i4.GetComponent<Text>();
        i5 = i5.GetComponent<Text>();

        if (pocetniReset == false)
        {
            pocetniReset = true;
            resetuj();
        }
    }

    // Update is called once per frame
    void Update () {
        player = bodovi.imeIgraca;
        bodovi1 = bodovi.pointsinGame;
        if (jednakocka.gameOver == true)
            for (int i = 0; i < 5; i++)
            {
                if (bodovi1 > highscore_bodovi[i] && jednakocka.upisaoIgraca == false)
                {
                    highscore_bodovi.Insert(i, bodovi1);
                    highscore_igraci.Insert(i, player);
                    highscore_bodovi.RemoveAt(5);
                    highscore_igraci.RemoveAt(5);
                    jednakocka.upisaoIgraca = true;
                    break;
                }
            }

        i1.text = highscore_igraci[0];
        i2.text = highscore_igraci[1];
        i3.text = highscore_igraci[2];
        i4.text = highscore_igraci[3];
        i5.text = highscore_igraci[4];
        b1.text = highscore_bodovi[0].ToString();
        b2.text = highscore_bodovi[1].ToString();
        b3.text = highscore_bodovi[2].ToString();
        b4.text = highscore_bodovi[3].ToString();
        b5.text = highscore_bodovi[4].ToString();
    }

    public void resetuj()
    {
        highscore_bodovi = new List<int>();
        highscore_igraci = new List<string>();
        highscore_bodovi.Add(0);
        highscore_bodovi.Add(0);
        highscore_bodovi.Add(0);
        highscore_bodovi.Add(0);
        highscore_bodovi.Add(0);
        highscore_igraci.Add("a");
        highscore_igraci.Add("b");
        highscore_igraci.Add("c");
        highscore_igraci.Add("d");
        highscore_igraci.Add("e");
    }
}
