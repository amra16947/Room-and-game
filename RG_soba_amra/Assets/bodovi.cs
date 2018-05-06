using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bodovi : MonoBehaviour {

    public static string imeIgraca = "";
    public static int pointsinGame;
    public static int zivotiinGame;
    public InputField unos;

	// Use this for initialization
	void Start () {
        unos = unos.GetComponent<InputField>();
        pointsinGame = jednakocka.poeni;
        zivotiinGame = jednabomba.zivoti;
    }
	
	// Update is called once per frame
	void Update () {
        if (unos.text != "")
        imeIgraca = unos.text;
        pointsinGame = jednakocka.poeni;
        zivotiinGame = jednabomba.zivoti;
    }
}
