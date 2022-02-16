using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveSystem_Script
{
    /* public static void SaveState(Player player)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "/gameSave.sav", FileMode.Create);

        PlayerData data = new PlayerData(player);

        bf.Serialize(stream, data);
        stream.Close();
    } */

    /*public static int[] LoadState()
    {
        if (File.Exists(Application.persistentDataPath + "/gameSave.sav"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "/gameSave.sav", FileMode.Open);

            PlayerData data = bf.Deserialize(stream) as PlayerData;
            stream.Close();
            return data.stats;
        }
    } */
}

[Serializable]
public class PlayerData
{
    public int[] stats;
    
    public PlayerData()
    {
        stats = new int[4];
        //stats[0] = player.type;
        //stats[1] = player.health;
        //stats[2] = player.attack;
        //stats[3] = player.position;
    }
}
