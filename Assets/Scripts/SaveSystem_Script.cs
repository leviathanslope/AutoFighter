using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class SaveSystem_Script: MonoBehaviour
{
    public static SaveSystem_Script ins;
    private void Awake()
    {
        ins = this;
    }

    public void SaveData()
    {
        Save save = createSaveGameObject();
        XmlDocument xmlDocument = new XmlDocument();

        #region Create XML Document Elements
        XmlElement root = xmlDocument.CreateElement("Save");
        root.SetAttribute("Filename", "File_01");

        XmlElement victoryPoints = xmlDocument.CreateElement("VictoryPoints");
        victoryPoints.InnerText = save.victoryPoints.ToString();
        root.AppendChild(victoryPoints);

        XmlElement playerHealth = xmlDocument.CreateElement("PlayerHealth");
        playerHealth.InnerText = save.playerHealth.ToString();
        root.AppendChild(playerHealth);

        XmlElement money = xmlDocument.CreateElement("Money");
        money.InnerText = save.money.ToString();
        root.AppendChild(money);
        #endregion

        xmlDocument.AppendChild(root);
        xmlDocument.Save(Application.persistentDataPath + "/Data.text");

        if (File.Exists(Application.persistentDataPath + "/Data.text"))
        {
            Debug.Log("XML FILED SAVED");
        }
    }

    public void LoadData()
    {
        string filePath = Application.persistentDataPath + "/Data.text";
        if (File.Exists(filePath))
        {
            Save save = new Save();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);

            XmlNodeList victoryPoints = xmlDocument.GetElementsByTagName("VictoryPoints");
            float victoryPointCount = float.Parse(victoryPoints[0].InnerText);
            save.victoryPoints = victoryPointCount;

            XmlNodeList playerHealth = xmlDocument.GetElementsByTagName("PlayerHealth");
            float playerHealthCount = float.Parse(playerHealth[0].InnerText);
            save.playerHealth = playerHealthCount;

            XmlNodeList money = xmlDocument.GetElementsByTagName("Money");
            float moneyCount = float.Parse(money[0].InnerText);
            save.money = moneyCount;

            GameManager.instance.victoryPoints = save.victoryPoints;
            GameManager.instance.playerHealth = save.playerHealth;
            GameManager.instance.money = save.money;
        } else
        {
            Debug.Log("NOT FOUND");
        }
    }

    private Save createSaveGameObject()
    {
        Save save = new Save();

        save.victoryPoints = GameManager.instance.victoryPoints;
        save.playerHealth = GameManager.instance.playerHealth;
        save.money = GameManager.instance.money;

        return save;
    }
}

[System.Serializable]
public class Units
{
    public string tag;
    public float health;
    public float attack;
    public string gameObject;
    public float positionX;
    public float positionY;
}

[System.Serializable]
public class UnitDatabase
{
    public List<Units> list = new List<Units>();
}

public class PlayerInfo
{
    public float victoryPoints;
    public float playerHealth;
    public float money;
}

public class PlayerDatabase
{
    public List<PlayerInfo> list = new List<PlayerInfo>();
}

public class EnemyInfo
{
    public string tag;
    public float health;
    public float attack;
    public string gameObject;
    public float positionX;
    public float positionY;
}

public class EnemyDatabase
{
    public List<EnemyInfo> list = new List<EnemyInfo>();
}

public class Save
{
    /*public float unitHealth;
    public float unitAttack;
    public string unitGameObject;
    public float unitPositionX;
    public float unitPositionY;*/

    public float victoryPoints;
    public float playerHealth;
    public float money;
}