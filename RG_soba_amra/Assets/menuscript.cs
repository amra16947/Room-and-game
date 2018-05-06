using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour {

    public Canvas novaMeni;
    public Canvas highscoreMeni;
    public Canvas helpMeni;
    public Canvas exitMeni;
    public Button novaDugme;
    public Button highscoreDugme;
    public Button helpDugme;
    public Button exitDugme;
    public Button prethodnaDugme;



    // Use this for initialization
    void Start () {
        novaMeni = novaMeni.GetComponent<Canvas>();
        highscoreMeni = highscoreMeni.GetComponent<Canvas>();
        helpMeni = helpMeni.GetComponent<Canvas>();
        exitMeni = exitMeni.GetComponent<Canvas>();
        novaDugme = novaDugme.GetComponent<Button>();
        highscoreDugme = highscoreDugme.GetComponent<Button>();
        helpDugme = helpDugme.GetComponent<Button>();
        exitDugme = exitDugme.GetComponent<Button>();
        prethodnaDugme = prethodnaDugme.GetComponent<Button>();

        novaMeni.enabled = false;
        highscoreMeni.enabled = false;
        helpMeni.enabled = false;
        exitMeni.enabled = false;
    }

    public void novaIgra()
    {
        novaMeni.enabled = true;

    }

    public void izaciNe()
    {
        exitMeni.enabled = false;
    }

    public void zapocniIgru()
    {
        jednakocka.gameOver = false;
        jednakocka.upisaoIgraca = false;
        bodovi.pointsinGame = 0;
        jednakocka.poeni = 0;
        jednabomba.zivoti = 5;
        jednakocka.jeLiPrva = true;
        SceneManager.LoadScene("novascena");
    }

    public void izaciDa()
    {
        Application.Quit();
    }

    public void DugmeBack()
    {
        novaMeni.enabled = false;
        highscoreMeni.enabled = false;
        helpMeni.enabled = false;
        exitMeni.enabled = false;
    }

    public void prikaziHighscore()
    {
        highscoreMeni.enabled = true;

    }

    public void prikaziHelp()
    {
        helpMeni.enabled = true;

    }

    public void prikaziExit()
    {
        exitMeni.enabled = true;

    }

    public void ucitajPrethodnu()
    {
        snimanjeUcitavanje.Load();
        Game.trenutna.ucitanaPrethodna();
        zapocniIgru();
        bodovi.pointsinGame = Game.trenutna.trenutni_bodovi;
        jednakocka.poeni = Game.trenutna.trenutni_bodovi;
    }







    static int i = 0;


    // Update is called once per frame
    void Update () {
        if (i < 5)
        {
            novaMeni.enabled = false;
            highscoreMeni.enabled = false;
            helpMeni.enabled = false;
            exitMeni.enabled = false;
        }
        i++;

    }
}
