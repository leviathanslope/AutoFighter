using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitManager_scr : MonoBehaviour
{

    public float _damage;
    public float _health;
    public string _type;

    public int _boardPos;
    public string _side;
    [SerializeField] Text _Healthtxt;
    [SerializeField] Text _Damagetxt;

    // Start is called before the first frame update
    void Start()
    {
        _sideDeclaration();
        _boardPosDeclaration();
        _stats();
    }

    void Update()
    {
        if (_health <= 0)
        {
            if (_type == "Healer")
            {
                _healerDeath();
            }
            if (_type == "Mage")
            {
                _mageDeath();
            }
            Destroy(gameObject);
        }

        _Healthtxt.text = _health.ToString();

        _Damagetxt.text = _damage.ToString();
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
            _health = 4;
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

    void _healerDeath()
    {
        if (_side == "Friendly")
        {
            if (_boardPos == 1 || _boardPos == 2)
            {
                if (GameObject.Find("FPos1") != null)
                {
                    GameObject _healing = GameObject.Find("FPos1");
                    _healing.GetComponent<UnitManager_scr>()._health += 2;
                }
                if (GameObject.Find("FPos2") != null)
                {
                    GameObject _healing = GameObject.Find("FPos2");
                    _healing.GetComponent<UnitManager_scr>()._health += 2;
                }
                if (GameObject.Find("FPos3") != null)
                {
                    GameObject _healing = GameObject.Find("FPos3");
                    _healing.GetComponent<UnitManager_scr>()._health += 2;
                }
                if (GameObject.Find("FPos4") != null)
                {
                    GameObject _healing = GameObject.Find("FPos4");
                    _healing.GetComponent<UnitManager_scr>()._health += 2;
                }
            }
        }
        else
        {
            if (_boardPos == 1 || _boardPos == 2)
            {
                if (GameObject.Find("EPos1") != null)
                {
                    GameObject _healing = GameObject.Find("EPos1");
                    _healing.GetComponent<UnitManager_scr>()._health += 2;
                }
                if (GameObject.Find("EPos2") != null)
                {
                    GameObject _healing = GameObject.Find("EPos2");
                    _healing.GetComponent<UnitManager_scr>()._health += 2;
                }
                if (GameObject.Find("EPos3") != null)
                {
                    GameObject _healing = GameObject.Find("EPos3");
                    _healing.GetComponent<UnitManager_scr>()._health += 2;
                }
                if (GameObject.Find("EPos4") != null)
                {
                    GameObject _healing = GameObject.Find("EPos4");
                    _healing.GetComponent<UnitManager_scr>()._health += 2;
                }
            }
        }
    }

    void _mageDeath()
    {
        if (_side == "Friendly")
        {
            if (_boardPos == 1)
            {
                if (GameObject.Find("EPos1") != null)
                {
                    GameObject _damaging = GameObject.Find("EPos1");
                    _damaging.GetComponent<UnitManager_scr>()._health -= 1;
                }
                if (GameObject.Find("EPos2") != null)
                {
                    GameObject _damaging = GameObject.Find("EPos2");
                    _damaging.GetComponent<UnitManager_scr>()._health -= 1;
                }
                if (GameObject.Find("EPos3") != null)
                {
                    GameObject _damaging = GameObject.Find("EPos3");
                    _damaging.GetComponent<UnitManager_scr>()._health -= 1;
                }
                if (GameObject.Find("EPos4") != null)
                {
                    GameObject _damaging = GameObject.Find("EPos4");
                    _damaging.GetComponent<UnitManager_scr>()._health -= 1;
                }
            }
            if (_boardPos == 2)
            {
                if (GameObject.Find("FPos1") != null)
                {
                    GameObject _damaging = GameObject.Find("FPos1");
                    _damaging.GetComponent<UnitManager_scr>()._damage += 1;
                }
                if (GameObject.Find("FPos2") != null)
                {
                    GameObject _damaging = GameObject.Find("FPos2");
                    _damaging.GetComponent<UnitManager_scr>()._damage += 1;
                }
                if (GameObject.Find("FPos3") != null)
                {
                    GameObject _damaging = GameObject.Find("FPos3");
                    _damaging.GetComponent<UnitManager_scr>()._damage += 1;
                }
                if (GameObject.Find("FPos4") != null)
                {
                    GameObject _damaging = GameObject.Find("FPos4");
                    _damaging.GetComponent<UnitManager_scr>()._damage += 1;
                }
            }
        }
        else
        {
            if (_boardPos == 1)
            {
                if (GameObject.Find("FPos1") != null)
                {
                    GameObject _damaging = GameObject.Find("FPos1");
                    _damaging.GetComponent<UnitManager_scr>()._health -= 1;
                }
                if (GameObject.Find("FPos2") != null)
                {
                    GameObject _damaging = GameObject.Find("FPos2");
                    _damaging.GetComponent<UnitManager_scr>()._health -= 1;
                }
                if (GameObject.Find("FPos3") != null)
                {
                    GameObject _damaging = GameObject.Find("FPos3");
                    _damaging.GetComponent<UnitManager_scr>()._health -= 1;
                }
                if (GameObject.Find("FPos4") != null)
                {
                    GameObject _damaging = GameObject.Find("FPos4");
                    _damaging.GetComponent<UnitManager_scr>()._health -= 1;
                }
            }
            if (_boardPos == 2)
            {
                if (GameObject.Find("EPos1") != null)
                {
                    GameObject _damaging = GameObject.Find("EPos1");
                    _damaging.GetComponent<UnitManager_scr>()._damage += 1;
                }
                if (GameObject.Find("EPos2") != null)
                {
                    GameObject _damaging = GameObject.Find("EPos2");
                    _damaging.GetComponent<UnitManager_scr>()._damage += 1;
                }
                if (GameObject.Find("EPos3") != null)
                {
                    GameObject _damaging = GameObject.Find("EPos3");
                    _damaging.GetComponent<UnitManager_scr>()._damage += 1;
                }
                if (GameObject.Find("EPos4") != null)
                {
                    GameObject _damaging = GameObject.Find("EPos4");
                    _damaging.GetComponent<UnitManager_scr>()._damage += 1;
                }
            }
        }
    }
}
