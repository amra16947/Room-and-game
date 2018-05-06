using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jednakocka : MonoBehaviour
{
    public Renderer kocka;
    public static int poeni = 0;
    public static List<Renderer> listaKocki = new List<Renderer>();
    public static List<Vector3moj> kocke = new List<Vector3moj>();
    public static bool gameOver = false;
    public static bool upisaoIgraca = false;
    public static bool ucitaoPrethodnuIgru = false;
    public static bool jeLiPrva = true;
    public bool trebaJeSkloniti = false;


    // Use this for initialization
    void Start()
    {
        kocka = kocka.GetComponent<Renderer>();

        if (jeLiPrva == true)
        {
            jeLiPrva = false;
            generisiKocku();
            generisiKocku();
            generisiKocku();
            generisiKocku();
            generisiKocku();
        }


        if (Time.frameCount == 18 && ucitaoPrethodnuIgru == false)
        {
            generisiKocku();
            generisiKocku();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ucitaoPrethodnuIgru == true)
        {
            foreach (Renderer r in listaKocki)
            {
                if (r != null)
                    Destroy(r);
            }
            listaKocki = new List<Renderer>();
            foreach (Vector3moj v in kocke)
            {
                Renderer kockica = (Renderer)Instantiate(kocka, v.ToVector3(), Quaternion.identity);
                listaKocki.Add(kockica);
            }

            ucitaoPrethodnuIgru = false;
        }

        /*
                if (listaKocki.Count >= 7)
                {
                    gameOver = true;
                    listaKocki.Clear();
                    SceneManager.LoadScene("igra");
                }*/



        if (Time.frameCount == 18)
        {
            generisiKocku();
            generisiKocku();

        }
    }
    
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(Time.frameCount + "     " + trebaJeSkloniti);
        if (trebaJeSkloniti == false)
        {
            transform.Translate(new Vector3(1000,1000,1000));
            poeni++;
            listaKocki.Remove(kocka);
            generisiKocku();
            trebaJeSkloniti = true;
        }
    }

    public void generisiKocku()
    {
        float desnaGranica = -15f;
        float lijevaGranica = 2f;
        float gornjaGranica = -12f;
        float donjaGranica = -20f;
        float pozicijaY = -5.5f;

        float randomBroj1 = Random.Range(0, 100) / 100.0f * (gornjaGranica - donjaGranica);
        float randomBroj2 = Random.Range(0, 100) / 100.0f * (lijevaGranica - desnaGranica);
        float iks = desnaGranica + randomBroj2, ipsilon = pozicijaY, cet = donjaGranica + randomBroj1;

        Renderer kockica = (Renderer)Instantiate(kocka, new Vector3(iks, ipsilon, cet), Quaternion.identity);
        listaKocki.Add(kockica);
    }

  

    }