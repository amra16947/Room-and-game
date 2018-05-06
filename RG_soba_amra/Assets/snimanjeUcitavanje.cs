using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using System;

public static class snimanjeUcitavanje {

    public static Game sada = new Game();

    public static void save()
    {
        try
        {
            snimanjeUcitavanje.sada = Game.trenutna;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(@"c:\MyTest.gd");
            bf.Serialize(file, snimanjeUcitavanje.sada);
            file.Close();
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }

    public static void Load()
    {
        if (File.Exists(@"c:\MyTest.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(@"c:\MyTest.gd", FileMode.Open);
            snimanjeUcitavanje.sada = (Game)bf.Deserialize(file);
            Game.trenutna = snimanjeUcitavanje.sada;
            file.Close();
        }
    }


}
