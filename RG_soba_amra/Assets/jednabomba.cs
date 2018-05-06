using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jednabomba : MonoBehaviour {

    public Renderer bomba;
    public static int zivoti = 5;
    public static List<Renderer> listaBombi = new List<Renderer>();
    public static List<Vector3moj> bombe = new List<Vector3moj>();
    public static bool gameOver = false;
    public static bool upisaoIgraca = false;
    public static bool ucitaoPrethodnuIgru = false;
    public static bool jeLiPrva = true;
    public bool trebaJeSkloniti = false;
    public static bool povecajBrojBombi = false;

    // Use this for initialization
    void Start()
    {

        if (jeLiPrva == true)
        {
            jeLiPrva = false;
            generisiBombu();
            generisiBombu();
        }


        bomba = bomba.GetComponent<Renderer>();

        if (Time.frameCount == 18 && ucitaoPrethodnuIgru == false)
        {
            generisiBombu();
            generisiBombu();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ucitaoPrethodnuIgru == true)
        {
            foreach (Renderer r in listaBombi)
            {
                if (r != null)
                    Destroy(r);
            }
            listaBombi = new List<Renderer>();
            foreach (Vector3moj v in bombe)
            {
                Renderer bombica = (Renderer)Instantiate(bomba, v.ToVector3(), Quaternion.identity);
                listaBombi.Add(bombica);
            }

            ucitaoPrethodnuIgru = false;

        }

        if (transform.position.x > 2f)
            transform.position = new Vector3(-15f, transform.position.y, transform.position.z);
        if (jednakocka.poeni >= 8 && jednakocka.poeni < 16) {
            transform.Translate(Vector3.right * 0.45f);
            if (povecajBrojBombi == false)
            {
                povecajBrojBombi = true;
                generisiBombu();
                povecajBrojBombi = true;
            }
        }
        else if (jednakocka.poeni >= 16)
        {
            transform.Translate(Vector3.right * 0.60f);
            if (povecajBrojBombi == false)
            {
                povecajBrojBombi = true;
                generisiBombu();
                povecajBrojBombi = true;
            }


        }
        else
            transform.Translate(Vector3.right * 0.1f);

        if (zivoti <= 0 )
        {
            gameOver = true;
            listaBombi.Clear();
            SceneManager.LoadScene("igra");
        }

    

        if (Time.frameCount == 18)
        {
            Destroy(bomba);
            listaBombi.Remove(bomba);
            generisiBombu();
            transform.position = new Vector3(-15f, transform.position.y, transform.position.z);
            transform.Translate(Vector3.right);


        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (trebaJeSkloniti == false)
        {
            zivoti--;
            transform.Translate(new Vector3(1000, 1000, 1000));
            Destroy(bomba);
            listaBombi.Remove(bomba);
            generisiBombu();
            trebaJeSkloniti = true;
        }
    }

    public static int a = 0;


public void generisiBombu()
    {
        float desnaGranica = -15f;
        float lijevaGranica = 2f;
        float gornjaGranica = -12f;
        float donjaGranica = -20f;
        float pozicijaY = -5.5f;

        float randomBroj1 = Random.Range(0, 100) / 100.0f * (gornjaGranica - donjaGranica);
        float randomBroj2 = Random.Range(0, 100) / 100.0f * (lijevaGranica - desnaGranica);
        float iks = desnaGranica + randomBroj2, ipsilon = pozicijaY, cet = donjaGranica + randomBroj1;
    
        Renderer bombica = (Renderer)Instantiate(bomba, new Vector3(iks, ipsilon, cet), Quaternion.identity);
        listaBombi.Add(bombica);
    }


}
