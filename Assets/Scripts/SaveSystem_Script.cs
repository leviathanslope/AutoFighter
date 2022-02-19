using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


/*
public static class SaveSystem_Script
{

     public static void SaveState(AutoBattlerController_scr player)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "/gameSave.sav", FileMode.Create);

        PlayerData data = new PlayerData(player);

        bf.Serialize(stream, data);
        stream.Close();
    }

    public static GameObject[] LoadState()
    {
        if (File.Exists(Application.persistentDataPath + "/gameSave.sav"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "/gameSave.sav", FileMode.Open);

            PlayerData data = bf.Deserialize(stream) as PlayerData;

            stream.Close();
            return data.objects;
        } else
        {
            return new GameObject[6];
        }
    }
}

[Serializable]
public class PlayerData
{
    public GameObject[] objects;
    public GameObject FU;
    public GameObject BLU;
    public GameObject BRU;
    public GameObject EFU;
    public GameObject ELU;
    public GameObject ERU;
    public PlayerData(AutoBattlerController_scr player)
    {

        objects = new GameObject[6];
        objects[0] = player.FrontU;
        objects[1] = player.BackLU;
        objects[2] = player.BackRU;
        objects[3] = player.FrontE;
        objects[4] = player.BackLE;
        objects[5] = player.BackRE;
    }
}
*/