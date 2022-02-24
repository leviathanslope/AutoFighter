using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager_scr : MonoBehaviour
{

    public float _damage;
    public float _health;
    public string _type;

    public int _boardPos;
    public string _side;

    // Start is called before the first frame update
    void Start()
    {
        _sideDeclaration();
        _boardPosDeclaration();
        _stats();
    }


    void _sideDeclaration()
    {
        // Checking if the unit will be labled a friednly unit or enemy
        if (transform.position.y > 0)
        {
            _side = "Enemy";
        }

        if (transform.position.y < 0)
        {
            _side = "Friendly";
        }
    }

    /// <summary>
    /// 
    /// _boardPosDeclaration is making a grid and checking where the gameobject is within it. 
    /// Depending on where the gameObject is on grid the controller knows if its in pos 1 2 3 or 4.
    /// 
    /// 
    /// </summary>
    void _boardPosDeclaration()
    {
        if (_side == "Enemy")
        {
            if (transform.position.x < 0 && transform.position.y < 1.5)
            {
                _boardPos = 1;
                gameObject.name = "EPos1";
            }
            if (transform.position.x > 0 && transform.position.y < 1.5)
            {
                _boardPos = 2;
                gameObject.name = "EPos2";
            }
            if (transform.position.x < 0 && transform.position.y > 1.5)
            {
                _boardPos = 3;
                gameObject.name = "EPos3";
            }
            if (transform.position.x > 0 && transform.position.y > 1.5)
            {
                _boardPos = 4;
                gameObject.name = "EPos4";
            }
        }

        if (_side == "Friendly")
        {
            if (transform.position.x < 0 && transform.position.y > -1.5)
            {
                _boardPos = 1;
                gameObject.name = "FPos1";
            }
            if (transform.position.x > 0 && transform.position.y > -1.5)
            {
                _boardPos = 2;
                gameObject.name = "FPos2";
            }
            if (transform.position.x < 0 && transform.position.y < -1.5)
            {
                _boardPos = 3;
                gameObject.name = "FPos3";
            }
            if (transform.position.x > 0 && transform.position.y < -1.5)
            {
                _boardPos = 4;
                gameObject.name = "FPos4";
            }
        }
    }

    void _stats()
    {
        if (gameObject.tag == "Archer")
        {
            _health = 1;
            _damage = 3;
            _type = "Archer";
        }
        if (gameObject.tag == "ShieldBearer")
        {
            _health = 3;
            _damage = 1;
            _type = "ShieldBearer";
        }
        if (gameObject.tag == "Healer")
        {
            _health = 2;
            _damage = 1;
            _type = "Healer";
        }
        if (gameObject.tag == "Swordsman")
        {
            _health = 2;
            _damage = 2;
            _type = "Swordsman";
        }
        if (gameObject.tag == "Mage")
        {
            _health = 1;
            _damage = 1;
            _type = "Mage";
        }
        if (gameObject.tag == "Spearman")
        {
            _health = 2;
            _damage = 2;
            _type = "Spearman";
        }
    }
}
