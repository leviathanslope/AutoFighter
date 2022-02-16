using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager_scr : MonoBehaviour
{

    public float health;
    public float attack;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "Archer")
        {
            health = 1;
            attack = 3;
        }
        if (gameObject.tag == "Healer")
        {
            health = 2;
            attack = 1;
        }
        if (gameObject.tag == "Mage")
        {
            health = 1;
            attack = 1;
        }
        if (gameObject.tag == "ShieldBearer")
        {
            health = 3;
            attack = 1;
        }
        if (gameObject.tag == "Swordsman")
        {
            health = 2;
            attack = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
