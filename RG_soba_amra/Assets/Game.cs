using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Game {
    public static Game trenutna = new Game();
    public int trenutni_bodovi;
    public int trenutni_zivoti;
    public string trenutni_igrac;
    public List<Vector3moj> kocke = new List<Vector3moj>();
    public List<Vector3moj> bombe = new List<Vector3moj>();
    public List<string> highscore_igraci;
    public List<int> highscore_bodovi;
    public float xSpasi;
    public float ySpasi;
    public float zSpasi;


    public Game()
    {
        trenutni_bodovi = jednakocka.poeni;
        trenutni_zivoti = jednabomba.zivoti;

        foreach (Renderer r in jednakocka.listaKocki)
            kocke.Add(new Vector3moj(r.transform.position.x, r.transform.position.y, r.transform.position.z));

        foreach (Renderer r in jednabomba.listaBombi)
            bombe.Add(new Vector3moj(r.transform.position.x, r.transform.position.y, r.transform.position.z));

        trenutni_igrac = bodovi.imeIgraca;
        highscore_igraci = highscoreSkripta.highscore_igraci;
        highscore_bodovi = highscoreSkripta.highscore_bodovi;
        xSpasi = kretanjeOsobe.xIgrac;
        ySpasi = kretanjeOsobe.yIgrac;
        zSpasi = kretanjeOsobe.zIgrac;
    }

    public void obradi_trenutnu()
    {
        trenutna.trenutni_bodovi = jednakocka.poeni;
        trenutna.trenutni_zivoti = jednabomba.zivoti;
        trenutna.kocke = new List<Vector3moj>();
        trenutna.bombe = new List<Vector3moj>();

        foreach (Renderer r in jednakocka.listaKocki)
            trenutna.kocke.Add(new Vector3moj(r.transform.position.x, r.transform.position.y, r.transform.position.z));

        foreach (Renderer r in jednabomba.listaBombi)
            trenutna.bombe.Add(new Vector3moj(r.transform.position.x, r.transform.position.y, r.transform.position.z));

        trenutna.trenutni_igrac = bodovi.imeIgraca;
        trenutna.highscore_igraci = highscoreSkripta.highscore_igraci;
        trenutna.highscore_bodovi = highscoreSkripta.highscore_bodovi;
        trenutna.xSpasi = kretanjeOsobe.xIgrac;
        trenutna.ySpasi = kretanjeOsobe.yIgrac;
        trenutna.zSpasi = kretanjeOsobe.zIgrac;
    }

    public void ucitanaPrethodna()
    {
        jednakocka.poeni = trenutna.trenutni_bodovi;
        jednakocka.kocke = trenutna.kocke;
        jednakocka.ucitaoPrethodnuIgru = true;
        jednabomba.bombe = trenutna.bombe;
        jednabomba.zivoti = trenutna.trenutni_zivoti;
        bodovi.imeIgraca = trenutna.trenutni_igrac;
        highscoreSkripta.highscore_igraci = trenutna.highscore_igraci;
        highscoreSkripta.highscore_bodovi = trenutna.highscore_bodovi;
        kretanjeOsobe.xIgrac = trenutna.xSpasi;
        kretanjeOsobe.yIgrac = trenutna.ySpasi;
        kretanjeOsobe.zIgrac = trenutna.zSpasi;
        kretanjeOsobe.ucitanaNova = true;
    }
}
