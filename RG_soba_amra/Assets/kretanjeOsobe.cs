using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kretanjeOsobe : MonoBehaviour {

    public float moveSpeed = 50f;
    public Text tekst;
    public Text tekstZivoti;
    public static float xIgrac;
    public static float yIgrac;
    public static float zIgrac;
    public static bool ucitanaNova = false;

    // Use this for initialization
    void Start () {
        tekst = tekst.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        Time.fixedDeltaTime = 0.01f;
        tekst.text = jednakocka.poeni.ToString();
        tekstZivoti.text = jednabomba.zivoti.ToString();
        if (ucitanaNova == true)
        {
            Vector3 poz = new Vector3(Game.trenutna.xSpasi, Game.trenutna.ySpasi, Game.trenutna.zSpasi);
            transform.position = poz;
            ucitanaNova = false;
        }
        xIgrac = transform.position.x;
        yIgrac = transform.position.y;
        zIgrac = transform.position.z;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.fixedDeltaTime);
        }
    }

    public void snimi()
    {
        Debug.Log(jednakocka.listaKocki.Count.ToString());
        Game.trenutna.obradi_trenutnu();
        snimanjeUcitavanje.save();
    }

    public void postaviPocetni()
    {

    }
}
