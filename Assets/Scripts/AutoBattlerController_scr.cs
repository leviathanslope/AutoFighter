using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBattlerController_scr : MonoBehaviour
{
    
    int _actionTick;
    string _type;

    GameObject EPos1;
    GameObject EPos2;
    GameObject EPos3;
    GameObject EPos4;

    GameObject FPos1;
    GameObject FPos2;
    GameObject FPos3;
    GameObject FPos4;



    // Start is called before the first frame update
    void Start()
    {
        _actionTick = 0;
        
        //LoadStats();
    }
    void LoadStats()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _actionTick++;
            pos1Action();
        }
    }

    void pos1Action()
    {
        
        //asking if there is an enemy in pos 1
        if (GameObject.Find("EPos1") != null)
        {
            EPos1 = GameObject.Find("EPos1");
            _type = EPos1.GetComponent<UnitManager_scr>()._type;
            getType();
        }
        //asking if their if a friend in pos 1
        if (GameObject.Find("FPos1") != null)
        {
            FPos1 = GameObject.Find("FPos1");
            _type = FPos1.GetComponent<UnitManager_scr>()._type;
            getType();
        }
    }

    void getType()
    {
        if (_type == "Archer")
        {
            FPos1.GetComponent<Archer_scr>()._pos1Combat();
        }
        if (_type == "ShieldBearer")
        {
            //GetComponent<Archer_scr>()._pos1Combat();
        }
        if (_type == "Healer")
        {
            //GetComponent<Archer_scr>()._pos1Combat();
        }
        if (_type == "Swordsman")
        {
            //GetComponent<Archer_scr>()._pos1Combat();
        }
        if (_type == "Mage")
        {
            //GetComponent<Archer_scr>()._pos1Combat();
        }
        if (_type == "Spearman")
        {
            //GetComponent<Archer_scr>()._pos1Combat();
        }
    }

}
