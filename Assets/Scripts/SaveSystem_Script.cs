using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class SaveSystem_Script: MonoBehaviour
{
    public static SaveSystem_Script ins;
    public GameObject swordUnit;
    public GameObject archerUnit;
    public GameObject mageUnit;
    public GameObject shieldUnit;
    public GameObject spearUnit;
    public GameObject healUnit;

    public GameObject FPos1;
    public GameObject FPos2;
    public GameObject FPos3;
    public GameObject FPos4;
    public GameObject EPos1;
    public GameObject EPos2;
    public GameObject EPos3;
    public GameObject EPos4;

    private void Awake()
    {
        if (ins == null)
        {
            ins = this;
        } else
        {
            if (ins != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
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

        XmlElement unit1Health = xmlDocument.CreateElement("Unit1Health");
        unit1Health.InnerText = save.unit1Health.ToString();
        root.AppendChild(unit1Health);
        XmlElement unit1Attack = xmlDocument.CreateElement("Unit1Attack");
        unit1Attack.InnerText = save.unit1Attack.ToString();
        root.AppendChild(unit1Attack);
        XmlElement unit1XPos = xmlDocument.CreateElement("Unit1XPos");
        unit1XPos.InnerText = save.unit1XPos.ToString();
        root.AppendChild(unit1XPos);
        XmlElement unit1YPos = xmlDocument.CreateElement("Unit1YPos");
        unit1YPos.InnerText = save.unit1YPos.ToString();
        root.AppendChild(unit1YPos);
        XmlElement unit1Tag = xmlDocument.CreateElement("Unit1Type");
        unit1Tag.InnerText = save.unit1Type.ToString();
        root.AppendChild(unit1Tag);

        XmlElement unit2Health = xmlDocument.CreateElement("Unit2Health");
        unit2Health.InnerText = save.unit2Health.ToString();
        root.AppendChild(unit2Health);
        XmlElement unit2Attack = xmlDocument.CreateElement("Unit2Attack");
        unit2Attack.InnerText = save.unit2Attack.ToString();
        root.AppendChild(unit2Attack);
        XmlElement unit2XPos = xmlDocument.CreateElement("Unit2XPos");
        unit2XPos.InnerText = save.unit2XPos.ToString();
        root.AppendChild(unit2XPos);
        XmlElement unit2YPos = xmlDocument.CreateElement("Unit2YPos");
        unit2YPos.InnerText = save.unit2YPos.ToString();
        root.AppendChild(unit2YPos);
        XmlElement unit2Tag = xmlDocument.CreateElement("Unit2Type");
        unit2Tag.InnerText = save.unit2Type.ToString();
        root.AppendChild(unit2Tag);

        XmlElement unit3Health = xmlDocument.CreateElement("Unit3Health");
        unit3Health.InnerText = save.unit3Health.ToString();
        root.AppendChild(unit3Health);
        XmlElement unit3Attack = xmlDocument.CreateElement("Unit3Attack");
        unit3Attack.InnerText = save.unit3Attack.ToString();
        root.AppendChild(unit3Attack);
        XmlElement unit3XPos = xmlDocument.CreateElement("Unit3XPos");
        unit3XPos.InnerText = save.unit3XPos.ToString();
        root.AppendChild(unit3XPos);
        XmlElement unit3YPos = xmlDocument.CreateElement("Unit3YPos");
        unit3YPos.InnerText = save.unit3YPos.ToString();
        root.AppendChild(unit3YPos);
        XmlElement unit3Tag = xmlDocument.CreateElement("Unit3Type");
        unit3Tag.InnerText = save.unit3Type.ToString();
        root.AppendChild(unit3Tag);

        XmlElement unit4Health = xmlDocument.CreateElement("Unit4Health");
        unit4Health.InnerText = save.unit4Health.ToString();
        root.AppendChild(unit4Health);
        XmlElement unit4Attack = xmlDocument.CreateElement("Unit4Attack");
        unit4Attack.InnerText = save.unit4Attack.ToString();
        root.AppendChild(unit4Attack);
        XmlElement unit4XPos = xmlDocument.CreateElement("Unit4XPos");
        unit4XPos.InnerText = save.unit4XPos.ToString();
        root.AppendChild(unit4XPos);
        XmlElement unit4YPos = xmlDocument.CreateElement("Unit4YPos");
        unit4YPos.InnerText = save.unit4YPos.ToString();
        root.AppendChild(unit4YPos);
        XmlElement unit4Tag = xmlDocument.CreateElement("Unit4Type");
        unit4Tag.InnerText = save.unit4Type.ToString();
        root.AppendChild(unit4Tag);

        XmlElement enemy1Health = xmlDocument.CreateElement("Enemy1Health");
        enemy1Health.InnerText = save.enemy1Health.ToString();
        root.AppendChild(enemy1Health);
        XmlElement enemy1Attack = xmlDocument.CreateElement("Enemy1Attack");
        enemy1Attack.InnerText = save.enemy1Attack.ToString();
        root.AppendChild(enemy1Attack);
        XmlElement enemy1XPos = xmlDocument.CreateElement("Enemy1XPos");
        enemy1XPos.InnerText = save.enemy1XPos.ToString();
        root.AppendChild(enemy1XPos);
        XmlElement enemy1YPos = xmlDocument.CreateElement("Enemy1YPos");
        enemy1YPos.InnerText = save.enemy1YPos.ToString();
        root.AppendChild(enemy1YPos);
        XmlElement enemy1Tag = xmlDocument.CreateElement("Enemy1Type");
        enemy1Tag.InnerText = save.enemy1Type.ToString();
        root.AppendChild(enemy1Tag);

        XmlElement enemy2Health = xmlDocument.CreateElement("Enemy2Health");
        enemy2Health.InnerText = save.enemy2Health.ToString();
        root.AppendChild(enemy2Health);
        XmlElement enemy2Attack = xmlDocument.CreateElement("Enemy2Attack");
        enemy2Attack.InnerText = save.enemy2Attack.ToString();
        root.AppendChild(enemy2Attack);
        XmlElement enemy2XPos = xmlDocument.CreateElement("Enemy2XPos");
        enemy2XPos.InnerText = save.enemy2XPos.ToString();
        root.AppendChild(enemy2XPos);
        XmlElement enemy2YPos = xmlDocument.CreateElement("Enemy2YPos");
        enemy2YPos.InnerText = save.enemy2YPos.ToString();
        root.AppendChild(enemy2YPos);
        XmlElement enemy2Tag = xmlDocument.CreateElement("Enemy2Type");
        enemy2Tag.InnerText = save.enemy2Type.ToString();
        root.AppendChild(enemy2Tag);

        XmlElement enemy3Health = xmlDocument.CreateElement("Enemy3Health");
        enemy3Health.InnerText = save.enemy3Health.ToString();
        root.AppendChild(enemy3Health);
        XmlElement enemy3Attack = xmlDocument.CreateElement("Enemy3Attack");
        enemy3Attack.InnerText = save.enemy3Attack.ToString();
        root.AppendChild(enemy3Attack);
        XmlElement enemy3XPos = xmlDocument.CreateElement("Enemy3XPos");
        enemy3XPos.InnerText = save.enemy3XPos.ToString();
        root.AppendChild(enemy3XPos);
        XmlElement enemy3YPos = xmlDocument.CreateElement("Enemy3YPos");
        enemy3YPos.InnerText = save.enemy3YPos.ToString();
        root.AppendChild(enemy3YPos);
        XmlElement enemy3Tag = xmlDocument.CreateElement("Enemy3Type");
        enemy3Tag.InnerText = save.enemy3Type;
        root.AppendChild(enemy3Tag);

        XmlElement enemy4Health = xmlDocument.CreateElement("Enemy4Health");
        enemy4Health.InnerText = save.enemy4Health.ToString();
        root.AppendChild(enemy4Health);
        XmlElement enemy4Attack = xmlDocument.CreateElement("Enemy4Attack");
        enemy4Attack.InnerText = save.enemy4Attack.ToString();
        root.AppendChild(enemy4Attack);
        XmlElement enemy4XPos = xmlDocument.CreateElement("Enemy4XPos");
        enemy4XPos.InnerText = save.enemy4XPos.ToString();
        root.AppendChild(enemy4XPos);
        XmlElement enemy4YPos = xmlDocument.CreateElement("Enemy4YPos");
        enemy4YPos.InnerText = save.enemy4YPos.ToString();
        root.AppendChild(enemy4YPos);
        XmlElement enemy4Tag = xmlDocument.CreateElement("Enemy4Type");
        enemy4Tag.InnerText = save.enemy4Type;
        root.AppendChild(enemy4Tag);
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

            XmlNodeList unit1Health = xmlDocument.GetElementsByTagName("Unit1Health");
            float unit1HealthCount = float.Parse(unit1Health[0].InnerText);
            save.unit1Health = unit1HealthCount;
            XmlNodeList unit1Attack = xmlDocument.GetElementsByTagName("Unit1Attack");
            float unit1AttackCount = float.Parse(unit1Attack[0].InnerText);
            save.unit1Attack = unit1AttackCount;
            XmlNodeList unit1XPos = xmlDocument.GetElementsByTagName("Unit1XPos");
            float unit1XPosition = float.Parse(unit1XPos[0].InnerText);
            save.unit1XPos = unit1XPosition;
            XmlNodeList unit1YPos = xmlDocument.GetElementsByTagName("Unit1YPos");
            float unit1YPosition = float.Parse(unit1YPos[0].InnerText);
            save.unit1YPos = unit1YPosition;
            XmlNodeList unit1Type = xmlDocument.GetElementsByTagName("Unit1Type");
            string unit1Tag = unit1Type[0].InnerText;
            save.unit1Type = unit1Tag;

            XmlNodeList unit2Health = xmlDocument.GetElementsByTagName("Unit2Health");
            float unit2HealthCount = float.Parse(unit2Health[0].InnerText);
            save.unit2Health = unit2HealthCount;
            XmlNodeList unit2Attack = xmlDocument.GetElementsByTagName("Unit2Attack");
            float unit2AttackCount = float.Parse(unit2Attack[0].InnerText);
            save.unit2Attack = unit2AttackCount;
            XmlNodeList unit2XPos = xmlDocument.GetElementsByTagName("Unit2XPos");
            float unit2XPosition = float.Parse(unit2XPos[0].InnerText);
            save.unit2XPos = unit2XPosition;
            XmlNodeList unit2YPos = xmlDocument.GetElementsByTagName("Unit2YPos");
            float unit2YPosition = float.Parse(unit2YPos[0].InnerText);
            save.unit2YPos = unit2YPosition;
            XmlNodeList unit2Type = xmlDocument.GetElementsByTagName("Unit2Type");
            string unit2Tag = unit2Type[0].InnerText;
            save.unit2Type = unit2Tag;

            XmlNodeList unit3Health = xmlDocument.GetElementsByTagName("Unit3Health");
            float unit3HealthCount = float.Parse(unit3Health[0].InnerText);
            save.unit3Health = unit3HealthCount;
            XmlNodeList unit3Attack = xmlDocument.GetElementsByTagName("Unit3Attack");
            float unit3AttackCount = float.Parse(unit3Attack[0].InnerText);
            save.unit3Attack = unit3AttackCount;
            XmlNodeList unit3XPos = xmlDocument.GetElementsByTagName("Unit3XPos");
            float unit3XPosition = float.Parse(unit3XPos[0].InnerText);
            save.unit3XPos = unit3XPosition;
            XmlNodeList unit3YPos = xmlDocument.GetElementsByTagName("Unit3YPos");
            float unit3YPosition = float.Parse(unit3YPos[0].InnerText);
            save.unit3YPos = unit3YPosition;
            XmlNodeList unit3Type = xmlDocument.GetElementsByTagName("Unit3Type");
            string unit3Tag = unit3Type[0].InnerText;
            save.unit3Type = unit3Tag;

            XmlNodeList unit4Health = xmlDocument.GetElementsByTagName("Unit4Health");
            float unit4HealthCount = float.Parse(unit4Health[0].InnerText);
            save.unit4Health = unit4HealthCount;
            XmlNodeList unit4Attack = xmlDocument.GetElementsByTagName("Unit4Attack");
            float unit4AttackCount = float.Parse(unit4Attack[0].InnerText);
            save.unit4Attack = unit4AttackCount;
            XmlNodeList unit4XPos = xmlDocument.GetElementsByTagName("Unit4XPos");
            float unit4XPosition = float.Parse(unit4XPos[0].InnerText);
            save.unit4XPos = unit4XPosition;
            XmlNodeList unit4YPos = xmlDocument.GetElementsByTagName("Unit4YPos");
            float unit4YPosition = float.Parse(unit4YPos[0].InnerText);
            save.unit4YPos = unit4YPosition;
            XmlNodeList unit4Type = xmlDocument.GetElementsByTagName("Unit4Type");
            string unit4Tag = unit4Type[0].InnerText;
            save.unit4Type = unit4Tag;

            XmlNodeList enemy1Health = xmlDocument.GetElementsByTagName("Enemy1Health");
            float enemy1HealthCount = float.Parse(enemy1Health[0].InnerText);
            save.enemy1Health = enemy1HealthCount;
            XmlNodeList enemy1Attack = xmlDocument.GetElementsByTagName("Enemy1Attack");
            float enemy1AttackCount = float.Parse(enemy1Attack[0].InnerText);
            save.enemy1Attack = enemy1AttackCount;
            XmlNodeList enemy1XPos = xmlDocument.GetElementsByTagName("Enemy1XPos");
            float enemy1XPosition = float.Parse(enemy1XPos[0].InnerText);
            save.enemy1XPos = enemy1XPosition;
            XmlNodeList enemy1YPos = xmlDocument.GetElementsByTagName("Enemy1YPos");
            float enemy1YPosition = float.Parse(enemy1YPos[0].InnerText);
            save.enemy1YPos = enemy1YPosition;
            XmlNodeList enemy1Type = xmlDocument.GetElementsByTagName("Enemy1Type");
            string enemy1Tag = enemy1Type[0].InnerText;
            save.enemy1Type = enemy1Tag;

            XmlNodeList enemy2Health = xmlDocument.GetElementsByTagName("Enemy2Health");
            float enemy2HealthCount = float.Parse(enemy2Health[0].InnerText);
            save.enemy2Health = enemy2HealthCount;
            XmlNodeList enemy2Attack = xmlDocument.GetElementsByTagName("Enemy2Attack");
            float enemy2AttackCount = float.Parse(enemy2Attack[0].InnerText);
            save.enemy2Attack = enemy2AttackCount;
            XmlNodeList enemy2XPos = xmlDocument.GetElementsByTagName("Enemy2XPos");
            float enemy2XPosition = float.Parse(enemy2XPos[0].InnerText);
            save.enemy2XPos = enemy2XPosition;
            XmlNodeList enemy2YPos = xmlDocument.GetElementsByTagName("Enemy2YPos");
            float enemy2YPosition = float.Parse(enemy2YPos[0].InnerText);
            save.enemy2YPos = enemy2YPosition;
            XmlNodeList enemy2Type = xmlDocument.GetElementsByTagName("Enemy2Type");
            string enemy2Tag = enemy2Type[0].InnerText;
            save.enemy2Type = enemy2Tag;

            XmlNodeList enemy3Health = xmlDocument.GetElementsByTagName("Enemy3Health");
            float enemy3HealthCount = float.Parse(enemy3Health[0].InnerText);
            save.enemy3Health = enemy3HealthCount;
            XmlNodeList enemy3Attack = xmlDocument.GetElementsByTagName("Enemy3Attack");
            float enemy3AttackCount = float.Parse(enemy3Attack[0].InnerText);
            save.enemy3Attack = enemy3AttackCount;
            XmlNodeList enemy3XPos = xmlDocument.GetElementsByTagName("Enemy3XPos");
            float enemy3XPosition = float.Parse(enemy3XPos[0].InnerText);
            save.enemy3XPos = enemy3XPosition;
            XmlNodeList enemy3YPos = xmlDocument.GetElementsByTagName("Enemy3YPos");
            float enemy3YPosition = float.Parse(enemy3YPos[0].InnerText);
            save.enemy3YPos = enemy3YPosition;
            XmlNodeList enemy3Type = xmlDocument.GetElementsByTagName("Enemy3Type");
            string enemy3Tag = enemy3Type[0].InnerText;
            save.enemy3Type = enemy3Tag;

            XmlNodeList enemy4Health = xmlDocument.GetElementsByTagName("Enemy4Health");
            float enemy4HealthCount = float.Parse(enemy4Health[0].InnerText);
            save.enemy4Health = enemy4HealthCount;
            XmlNodeList enemy4Attack = xmlDocument.GetElementsByTagName("Enemy4Attack");
            float enemy4AttackCount = float.Parse(enemy4Attack[0].InnerText);
            save.enemy4Attack = enemy4AttackCount;
            XmlNodeList enemy4XPos = xmlDocument.GetElementsByTagName("Enemy4XPos");
            float enemy4XPosition = float.Parse(enemy4XPos[0].InnerText);
            save.enemy4XPos = enemy4XPosition;
            XmlNodeList enemy4YPos = xmlDocument.GetElementsByTagName("Enemy4YPos");
            float enemy4YPosition = float.Parse(enemy4YPos[0].InnerText);
            save.enemy4YPos = enemy4YPosition;
            XmlNodeList enemy4Type = xmlDocument.GetElementsByTagName("Enemy4Type");
            string enemy4Tag = enemy4Type[0].InnerText;
            save.enemy4Type = enemy4Tag;

            if (unit1Tag == "Mage")
            {
                float xPos = save.unit1XPos;
                float yPos = save.unit1YPos;
                GameObject mage = Instantiate(mageUnit, new Vector2(xPos, yPos), Quaternion.identity);
                mage.gameObject.GetComponent<UnitManager_scr>()._health = save.unit1Health;
                mage.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit1Attack;
                
            } else if (unit1Tag == "Archer")
            {
                float xPos = save.unit1XPos;
                float yPos = save.unit1YPos;
                GameObject archer = Instantiate(archerUnit, new Vector2(xPos, yPos), Quaternion.identity);
                archer.gameObject.GetComponent<UnitManager_scr>()._health = save.unit1Health;
                archer.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit1Attack;
            } else if (unit1Tag == "Healer")
            {
                float xPos = save.unit1XPos;
                float yPos = save.unit1YPos;
                GameObject healer = Instantiate(healUnit, new Vector2(xPos, yPos), Quaternion.identity);
                healer.gameObject.GetComponent<UnitManager_scr>()._health = save.unit1Health;
                healer.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit1Attack;
            } else if (unit1Tag == "ShieldBearer")
            {
                float xPos = save.unit1XPos;
                float yPos = save.unit1YPos;
                GameObject shield = Instantiate(shieldUnit, new Vector2(xPos, yPos), Quaternion.identity);
                shield.gameObject.GetComponent<UnitManager_scr>()._health = save.unit1Health;
                shield.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit1Attack;
            } else if (unit1Tag == "Spearman")
            {
                float xPos = save.unit1XPos;
                float yPos = save.unit1YPos;
                GameObject spear = Instantiate(spearUnit, new Vector2(xPos, yPos), Quaternion.identity);
                spear.gameObject.GetComponent<UnitManager_scr>()._health = save.unit1Health;
                spear.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit1Attack;
            } else if (unit1Tag == "Swordsman")
            {
                float xPos = save.unit1XPos;
                float yPos = save.unit1YPos;
                GameObject sword = Instantiate(swordUnit, new Vector2(xPos, yPos), Quaternion.identity);
                sword.gameObject.GetComponent<UnitManager_scr>()._health = save.unit1Health;
                sword.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit1Attack;
            }

            if (unit2Tag == "Mage")
            {
                float xPos = save.unit2XPos;
                float yPos = save.unit2YPos;
                GameObject mage = Instantiate(mageUnit, new Vector2(xPos, yPos), Quaternion.identity);
                mage.gameObject.GetComponent<UnitManager_scr>()._health = save.unit2Health;
                mage.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit2Attack;

            }
            else if (unit2Tag == "Archer")
            {
                float xPos = save.unit2XPos;
                float yPos = save.unit2YPos;
                GameObject archer = Instantiate(archerUnit, new Vector2(xPos, yPos), Quaternion.identity);
                archer.gameObject.GetComponent<UnitManager_scr>()._health = save.unit2Health;
                archer.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit2Attack;
            }
            else if (unit2Tag == "Healer")
            {
                float xPos = save.unit2XPos;
                float yPos = save.unit2YPos;
                GameObject healer = Instantiate(healUnit, new Vector2(xPos, yPos), Quaternion.identity);
                healer.gameObject.GetComponent<UnitManager_scr>()._health = save.unit2Health;
                healer.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit2Attack;
            }
            else if (unit2Tag == "ShieldBearer")
            {
                float xPos = save.unit2XPos;
                float yPos = save.unit2YPos;
                GameObject shield = Instantiate(shieldUnit, new Vector2(xPos, yPos), Quaternion.identity);
                shield.gameObject.GetComponent<UnitManager_scr>()._health = save.unit2Health;
                shield.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit2Attack;
            }
            else if (unit2Tag == "Spearman")
            {
                float xPos = save.unit2XPos;
                float yPos = save.unit2YPos;
                GameObject spear = Instantiate(spearUnit, new Vector2(xPos, yPos), Quaternion.identity);
                spear.gameObject.GetComponent<UnitManager_scr>()._health = save.unit2Health;
                spear.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit2Attack;
            }
            else if (unit2Tag == "Swordsman")
            {
                float xPos = save.unit2XPos;
                float yPos = save.unit2YPos;
                GameObject sword = Instantiate(swordUnit, new Vector2(xPos, yPos), Quaternion.identity);
                sword.gameObject.GetComponent<UnitManager_scr>()._health = save.unit2Health;
                sword.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit2Attack;
            }

            if (unit3Tag == "Mage")
            {
                float xPos = save.unit1XPos;
                float yPos = save.unit1YPos;
                GameObject mage = Instantiate(mageUnit, new Vector2(xPos, yPos), Quaternion.identity);
                mage.gameObject.GetComponent<UnitManager_scr>()._health = save.unit1Health;
                mage.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit1Attack;

            }
            else if (unit3Tag == "Archer")
            {
                float xPos = save.unit3XPos;
                float yPos = save.unit3YPos;
                GameObject archer = Instantiate(archerUnit, new Vector2(xPos, yPos), Quaternion.identity);
                archer.gameObject.GetComponent<UnitManager_scr>()._health = save.unit3Health;
                archer.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit3Attack;
            }
            else if (unit3Tag == "Healer")
            {
                float xPos = save.unit3XPos;
                float yPos = save.unit3YPos;
                GameObject healer = Instantiate(healUnit, new Vector2(xPos, yPos), Quaternion.identity);
                healer.gameObject.GetComponent<UnitManager_scr>()._health = save.unit3Health;
                healer.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit3Attack;
            }
            else if (unit3Tag == "ShieldBearer")
            {
                float xPos = save.unit3XPos;
                float yPos = save.unit3YPos;
                GameObject shield = Instantiate(shieldUnit, new Vector2(xPos, yPos), Quaternion.identity);
                shield.gameObject.GetComponent<UnitManager_scr>()._health = save.unit3Health;
                shield.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit3Attack;
            }
            else if (unit3Tag == "Spearman")
            {
                float xPos = save.unit3XPos;
                float yPos = save.unit3YPos;
                GameObject spear = Instantiate(spearUnit, new Vector2(xPos, yPos), Quaternion.identity);
                spear.gameObject.GetComponent<UnitManager_scr>()._health = save.unit3Health;
                spear.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit3Attack;
            }
            else if (unit3Tag == "Swordsman")
            {
                float xPos = save.unit3XPos;
                float yPos = save.unit3YPos;
                GameObject sword = Instantiate(swordUnit, new Vector2(xPos, yPos), Quaternion.identity);
                sword.gameObject.GetComponent<UnitManager_scr>()._health = save.unit3Health;
                sword.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit3Attack;
            }

            if (unit4Tag == "Mage")
            {
                float xPos = save.unit2XPos;
                float yPos = save.unit2YPos;
                GameObject mage = Instantiate(mageUnit, new Vector2(xPos, yPos), Quaternion.identity);
                mage.gameObject.GetComponent<UnitManager_scr>()._health = save.unit2Health;
                mage.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit2Attack;

            }
            else if (unit4Tag == "Archer")
            {
                float xPos = save.unit4XPos;
                float yPos = save.unit4YPos;
                GameObject archer = Instantiate(archerUnit, new Vector2(xPos, yPos), Quaternion.identity);
                archer.gameObject.GetComponent<UnitManager_scr>()._health = save.unit4Health;
                archer.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit4Attack;
            }
            else if (unit4Tag == "Healer")
            {
                float xPos = save.unit4XPos;
                float yPos = save.unit4YPos;
                GameObject healer = Instantiate(healUnit, new Vector2(xPos, yPos), Quaternion.identity);
                healer.gameObject.GetComponent<UnitManager_scr>()._health = save.unit4Health;
                healer.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit4Attack;
            }
            else if (unit4Tag == "ShieldBearer")
            {
                float xPos = save.unit4XPos;
                float yPos = save.unit4YPos;
                GameObject shield = Instantiate(shieldUnit, new Vector2(xPos, yPos), Quaternion.identity);
                shield.gameObject.GetComponent<UnitManager_scr>()._health = save.unit4Health;
                shield.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit4Attack;
            }
            else if (unit4Tag == "Spearman")
            {
                float xPos = save.unit4XPos;
                float yPos = save.unit4YPos;
                GameObject spear = Instantiate(spearUnit, new Vector2(xPos, yPos), Quaternion.identity);
                spear.gameObject.GetComponent<UnitManager_scr>()._health = save.unit4Health;
                spear.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit4Attack;
            }
            else if (unit4Tag == "Swordsman")
            {
                float xPos = save.unit4XPos;
                float yPos = save.unit4YPos;
                GameObject sword = Instantiate(swordUnit, new Vector2(xPos, yPos), Quaternion.identity);
                sword.gameObject.GetComponent<UnitManager_scr>()._health = save.unit4Health;
                sword.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit4Attack;
            }

            if (enemy1Tag == "Mage")
            {
                float xPos = save.unit2XPos;
                float yPos = save.unit2YPos;
                GameObject mage = Instantiate(mageUnit, new Vector2(xPos, yPos), Quaternion.identity);
                mage.gameObject.GetComponent<UnitManager_scr>()._health = save.unit2Health;
                mage.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit2Attack;

            }
            else if (enemy1Tag == "Archer")
            {
                float xPos = save.enemy1XPos;
                float yPos = save.enemy1YPos;
                GameObject archer = Instantiate(archerUnit, new Vector2(xPos, yPos), Quaternion.identity);
                archer.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy1Health;
                archer.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy1Attack;
            }
            else if (enemy1Tag == "Healer")
            {
                float xPos = save.enemy1XPos;
                float yPos = save.enemy1YPos;
                GameObject healer = Instantiate(healUnit, new Vector2(xPos, yPos), Quaternion.identity);
                healer.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy1Health;
                healer.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy1Attack;
            }
            else if (enemy1Tag == "ShieldBearer")
            {
                float xPos = save.enemy1XPos;
                float yPos = save.enemy1YPos;
                GameObject shield = Instantiate(shieldUnit, new Vector2(xPos, yPos), Quaternion.identity);
                shield.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy1Health;
                shield.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy1Attack;
            }
            else if (enemy1Tag == "Spearman")
            {
                float xPos = save.enemy1XPos;
                float yPos = save.enemy1YPos;
                GameObject spear = Instantiate(spearUnit, new Vector2(xPos, yPos), Quaternion.identity);
                spear.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy1Health;
                spear.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy1Attack;
            }
            else if (enemy1Tag == "Swordsman")
            {
                float xPos = save.enemy1XPos;
                float yPos = save.enemy1YPos;
                GameObject sword = Instantiate(swordUnit, new Vector2(xPos, yPos), Quaternion.identity);
                sword.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy1Health;
                sword.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy1Attack;
            }

            if (enemy2Tag == "Mage")
            {
                float xPos = save.unit2XPos;
                float yPos = save.unit2YPos;
                GameObject mage = Instantiate(mageUnit, new Vector2(xPos, yPos), Quaternion.identity);
                mage.gameObject.GetComponent<UnitManager_scr>()._health = save.unit2Health;
                mage.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit2Attack;

            }
            else if (enemy2Tag == "Archer")
            {
                float xPos = save.enemy2XPos;
                float yPos = save.enemy2YPos;
                GameObject archer = Instantiate(archerUnit, new Vector2(xPos, yPos), Quaternion.identity);
                archer.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy2Health;
                archer.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy2Attack;
            }
            else if (enemy2Tag == "Healer")
            {
                float xPos = save.enemy2XPos;
                float yPos = save.enemy2YPos;
                GameObject healer = Instantiate(healUnit, new Vector2(xPos, yPos), Quaternion.identity);
                healer.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy2Health;
                healer.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy2Attack;
            }
            else if (enemy2Tag == "ShieldBearer")
            {
                float xPos = save.enemy2XPos;
                float yPos = save.enemy2YPos;
                GameObject shield = Instantiate(shieldUnit, new Vector2(xPos, yPos), Quaternion.identity);
                shield.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy2Health;
                shield.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy2Attack;
            }
            else if (enemy2Tag == "Spearman")
            {
                float xPos = save.enemy2XPos;
                float yPos = save.enemy2YPos;
                GameObject spear = Instantiate(spearUnit, new Vector2(xPos, yPos), Quaternion.identity);
                spear.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy2Health;
                spear.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy2Attack;
            }
            else if (enemy2Tag == "Swordsman")
            {
                float xPos = save.enemy2XPos;
                float yPos = save.enemy2YPos;
                GameObject sword = Instantiate(swordUnit, new Vector2(xPos, yPos), Quaternion.identity);
                sword.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy2Health;
                sword.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy2Attack;
            }

            if (enemy3Tag == "Mage")
            {
                float xPos = save.unit2XPos;
                float yPos = save.unit2YPos;
                GameObject mage = Instantiate(mageUnit, new Vector2(xPos, yPos), Quaternion.identity);
                mage.gameObject.GetComponent<UnitManager_scr>()._health = save.unit2Health;
                mage.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit2Attack;

            }
            else if (enemy3Tag == "Archer")
            {
                float xPos = save.enemy3XPos;
                float yPos = save.enemy3YPos;
                GameObject archer = Instantiate(archerUnit, new Vector2(xPos, yPos), Quaternion.identity);
                archer.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy3Health;
                archer.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy3Attack;
            }
            else if (enemy3Tag == "Healer")
            {
                float xPos = save.enemy3XPos;
                float yPos = save.enemy3YPos;
                GameObject healer = Instantiate(healUnit, new Vector2(xPos, yPos), Quaternion.identity);
                healer.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy3Health;
                healer.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy3Attack;
            }
            else if (enemy3Tag == "ShieldBearer")
            {
                float xPos = save.enemy3XPos;
                float yPos = save.enemy3YPos;
                GameObject shield = Instantiate(shieldUnit, new Vector2(xPos, yPos), Quaternion.identity);
                shield.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy3Health;
                shield.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy3Attack;
            }
            else if (enemy3Tag == "Spearman")
            {
                float xPos = save.enemy3XPos;
                float yPos = save.enemy3YPos;
                GameObject spear = Instantiate(spearUnit, new Vector2(xPos, yPos), Quaternion.identity);
                spear.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy3Health;
                spear.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy3Attack;
            }
            else if (enemy3Tag == "Swordsman")
            {
                float xPos = save.enemy3XPos;
                float yPos = save.enemy3YPos;
                GameObject sword = Instantiate(swordUnit, new Vector2(xPos, yPos), Quaternion.identity);
                sword.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy3Health;
                sword.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy3Attack;
            }

            if (enemy4Tag == "Mage")
            {
                float xPos = save.unit2XPos;
                float yPos = save.unit2YPos;
                GameObject mage = Instantiate(mageUnit, new Vector2(xPos, yPos), Quaternion.identity);
                mage.gameObject.GetComponent<UnitManager_scr>()._health = save.unit2Health;
                mage.gameObject.GetComponent<UnitManager_scr>()._damage = save.unit2Attack;

            }
            else if (enemy4Tag == "Archer")
            {
                float xPos = save.enemy4XPos;
                float yPos = save.enemy4YPos;
                GameObject archer = Instantiate(archerUnit, new Vector2(xPos, yPos), Quaternion.identity);
                archer.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy4Health;
                archer.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy4Attack;
            }
            else if (enemy4Tag == "Healer")
            {
                float xPos = save.enemy4XPos;
                float yPos = save.enemy4YPos;
                GameObject healer = Instantiate(healUnit, new Vector2(xPos, yPos), Quaternion.identity);
                healer.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy4Health;
                healer.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy4Attack;
            }
            else if (enemy4Tag == "ShieldBearer")
            {
                float xPos = save.enemy4XPos;
                float yPos = save.enemy4YPos;
                GameObject shield = Instantiate(shieldUnit, new Vector2(xPos, yPos), Quaternion.identity);
                shield.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy4Health;
                shield.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy4Attack;
            }
            else if (enemy4Tag == "Spearman")
            {
                float xPos = save.enemy4XPos;
                float yPos = save.enemy4YPos;
                GameObject spear = Instantiate(spearUnit, new Vector2(xPos, yPos), Quaternion.identity);
                spear.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy4Health;
                spear.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy4Attack;
            }
            else if (enemy4Tag == "Swordsman")
            {
                float xPos = save.enemy4XPos;
                float yPos = save.enemy4YPos;
                GameObject sword = Instantiate(swordUnit, new Vector2(xPos, yPos), Quaternion.identity);
                sword.gameObject.GetComponent<UnitManager_scr>()._health = save.enemy4Health;
                sword.gameObject.GetComponent<UnitManager_scr>()._damage = save.enemy4Attack;
            }
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

        if (FPos1 != null)
        {
            save.unit1Health = FPos1.GetComponent<UnitManager_scr>()._health;
            save.unit1Attack = FPos1.GetComponent<UnitManager_scr>()._damage;
            save.unit1XPos = FPos1.transform.position.x;
            save.unit1YPos = FPos1.transform.position.y;
            save.unit1Type = FPos1.tag;
        } else
        {
            save.unit1Health = 0;
            save.unit1Attack = 0;
            save.unit1XPos = 0;
            save.unit1YPos = 0;
            save.unit1Type = "None";
        }

        if (FPos2 != null)
        {
            save.unit2Health = FPos2.GetComponent<UnitManager_scr>()._health;
            save.unit2Attack = FPos2.GetComponent<UnitManager_scr>()._damage;
            save.unit2XPos = FPos2.transform.position.x;
            save.unit2YPos = FPos2.transform.position.y;
            save.unit2Type = FPos2.tag;
        }
        else
        {
            save.unit2Health = 0;
            save.unit2Attack = 0;
            save.unit2XPos = 0;
            save.unit2YPos = 0;
            save.unit2Type = "None";
        }

        if (FPos3 != null)
        {
            save.unit3Health = FPos3.GetComponent<UnitManager_scr>()._health;
            save.unit3Attack = FPos3.GetComponent<UnitManager_scr>()._damage;
            save.unit3XPos = FPos3.transform.position.x;
            save.unit3YPos = FPos3.transform.position.y;
            save.unit3Type = FPos3.tag;
        }
        else
        {
            save.unit3Health = 0;
            save.unit3Attack = 0;
            save.unit3XPos = 0;
            save.unit3YPos = 0;
            save.unit3Type = "None";
        }

        if (FPos4 != null)
        {
            save.unit4Health = FPos4.GetComponent<UnitManager_scr>()._health;
            save.unit4Attack = FPos4.GetComponent<UnitManager_scr>()._damage;
            save.unit4XPos = FPos4.transform.position.x;
            save.unit4YPos = FPos4.transform.position.y;
            save.unit4Type = FPos4.tag;
        }
        else
        {
            save.unit4Health = 0;
            save.unit4Attack = 0;
            save.unit4XPos = 0;
            save.unit4YPos = 0;
            save.unit4Type = "None";
        }

        if (EPos1 != null)
        {
            save.enemy1Health = EPos1.GetComponent<UnitManager_scr>()._health;
            save.enemy1Attack = EPos1.GetComponent<UnitManager_scr>()._damage;
            save.enemy1XPos = EPos1.transform.position.x;
            save.enemy1YPos = EPos1.transform.position.y;
            save.enemy1Type = EPos1.tag;
        }
        else
        {
            save.enemy1Health = 0;
            save.enemy1Attack = 0;
            save.enemy1XPos = 0;
            save.enemy1YPos = 0;
            save.enemy1Type = "None";
        }

        if (EPos2 != null)
        {
            save.enemy2Health = EPos2.GetComponent<UnitManager_scr>()._health;
            save.enemy2Attack = EPos2.GetComponent<UnitManager_scr>()._damage;
            save.enemy2XPos = EPos2.transform.position.x;
            save.enemy2YPos = EPos2.transform.position.y;
            save.enemy2Type = EPos2.tag;
        }
        else
        {
            save.enemy2Health = 0;
            save.enemy2Attack = 0;
            save.enemy2XPos = 0;
            save.enemy2YPos = 0;
            save.enemy2Type = "None";
        }

        if (EPos3 != null)
        {
            save.enemy3Health = EPos3.GetComponent<UnitManager_scr>()._health;
            save.enemy3Attack = EPos3.GetComponent<UnitManager_scr>()._damage;
            save.enemy3XPos = EPos3.transform.position.x;
            save.enemy3YPos = EPos3.transform.position.y;
            save.enemy3Type = EPos3.tag;
        }
        else
        {
            save.enemy3Health = 0;
            save.enemy3Attack = 0;
            save.enemy3XPos = 0;
            save.enemy3YPos = 0;
            save.enemy3Type = "None";
        }

        if (EPos4 != null)
        {
            save.enemy4Health = EPos1.GetComponent<UnitManager_scr>()._health;
            save.enemy4Attack = EPos1.GetComponent<UnitManager_scr>()._damage;
            save.enemy4XPos = EPos1.transform.position.x;
            save.enemy4YPos = EPos1.transform.position.y;
            save.enemy4Type = EPos1.tag;
        }
        else
        {
            save.enemy4Health = 0;
            save.enemy4Attack = 0;
            save.enemy4XPos = 0;
            save.enemy4YPos = 0;
            save.enemy4Type = "None";
        }

        return save;
    }
}

[System.Serializable]
public class Units
{
    public string tag;
    public float health;
    public float attack;
    public float positionX;
    public float positionY;
}

public class EnemyInfo
{
    public string tag;
    public float health;
    public float attack;
    public float positionX;
    public float positionY;
}

public class Save
{
    public float victoryPoints;
    public float playerHealth;
    public float money;

    public float unit1Health;
    public float unit1Attack;
    public float unit1XPos;
    public float unit1YPos;
    public string unit1Type;

    public float unit2Health;
    public float unit2Attack;
    public float unit2XPos;
    public float unit2YPos;
    public string unit2Type;

    public float unit3Health;
    public float unit3Attack;
    public float unit3XPos;
    public float unit3YPos;
    public string unit3Type;

    public float unit4Health;
    public float unit4Attack;
    public float unit4XPos;
    public float unit4YPos;
    public string unit4Type;

    public float enemy1Health;
    public float enemy1Attack;
    public float enemy1XPos;
    public float enemy1YPos;
    public string enemy1Type;

    public float enemy2Health;
    public float enemy2Attack;
    public float enemy2XPos;
    public float enemy2YPos;
    public string enemy2Type;

    public float enemy3Health;
    public float enemy3Attack;
    public float enemy3XPos;
    public float enemy3YPos;
    public string enemy3Type;

    public float enemy4Health;
    public float enemy4Attack;
    public float enemy4XPos;
    public float enemy4YPos;
    public string enemy4Type;
}