using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer_scr : MonoBehaviour
{
    string _side;
    int _boardPos;

    float _health;
    float _damage;
    int _actionTick;

    bool _UsedAction;

    // Start is called before the first frame update
    void Start()
    {   
        _UsedAction = false;
    }

    void Update()
    {
        _health = gameObject.GetComponent<UnitManager_scr>()._health;
        _damage = gameObject.GetComponent<UnitManager_scr>()._damage;
        _boardPos = gameObject.GetComponent<UnitManager_scr>()._boardPos;
        _side = gameObject.GetComponent<UnitManager_scr>()._side;

        _actionTick = GameObject.FindWithTag("AutoBattlerController").GetComponent<AutoBattlerController_scr>()._actionTick;


        callForAction();
    }

    void callForAction()
    {
        if (_actionTick > _boardPos)
        {
            _UsedAction = false;
        }
        if (_boardPos == 4 & _actionTick == 1)
        {
            _UsedAction = false;
        }
        if (_UsedAction == false && _actionTick == 1 && _boardPos == 1)
        {
            _UsedAction = true;
            _pos1Combat();
        }
        if (_UsedAction == false && _actionTick == 2 && _boardPos == 2)
        {
            _UsedAction = true;
            _pos2Combat();
        }
        if (_UsedAction == false && _actionTick == 3 && _boardPos == 3)
        {
            _UsedAction = true;
            _pos3Combat();
        }
        if (_UsedAction == false && _actionTick == 4 && _boardPos == 4)
        {
            _UsedAction = true;
            _pos4Combat();
        }
    }
    //called if gameObject in board position 1
    public void _pos1Combat()
    {
        //checking if the unit is friendly
        if (_side == "Friendly")
        {
            //checking for shield bearers
            if (GameObject.Find("EPos1") != null && GameObject.Find("EPos1").tag == "ShieldBearer")
            {
                GameObject _attacking = GameObject.Find("EPos1");
                _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
            }
            else if (GameObject.Find("EPos2") != null && GameObject.Find("EPos2").tag == "ShieldBearer")
            {
                GameObject _attacking = GameObject.Find("EPos2");
                _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
            }
            //standard action if there are no shield bearers
            //asking if an enemy exist in pos 4
            else if (GameObject.Find("EPos4") != null)
            {
                GameObject _attacking = GameObject.Find("EPos4");

                _attacking.GetComponent<UnitManager_scr>()._health -= _damage;

            }
            //asking if an enemy exist in pos 1
            else if (GameObject.Find("EPos1") != null)
            {
                GameObject _attacking = GameObject.Find("EPos1");

                _attacking.GetComponent<UnitManager_scr>()._health -= _damage;

            }
            //asking if an enemy exist in pos 2
            else if (GameObject.Find("EPos2") != null)
            {
                GameObject _attacking = GameObject.Find("EPos2");

                _attacking.GetComponent<UnitManager_scr>()._health -= _damage;

            }
        }
        //enemy section
        else
        {
            //checking for shield bearers
            if (GameObject.Find("FPos1") != null && GameObject.Find("FPos1").tag == "ShieldBearer")
            {
                GameObject _attacking = GameObject.Find("FPos1");
                _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
            }
            else if (GameObject.Find("FPos2") != null && GameObject.Find("FPos2").tag == "ShieldBearer")
            {
                GameObject _attacking = GameObject.Find("FPos2");
                _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
            }
            //standard action if there are no shield bearers
            //asking if a friend is in Position 3 exist
            else if (GameObject.Find("FPos3") != null)
            {
                GameObject _attacking = GameObject.Find("FPos3");

                _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
            }
            //asking if a friend is exist in pos 4
            else if (GameObject.Find("FPos4") != null)
            {
                GameObject _attacking = GameObject.Find("FPos4");

               _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
            }
            //asking if a friend is exist in pos 1
            else if (GameObject.Find("FPos1") != null)
            {
                GameObject _attacking = GameObject.Find("FPos1");

                _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
            }
            //asking if a friend is exist in pos 2
            else if (GameObject.Find("FPos2") != null)
            {
                GameObject _attacking = GameObject.Find("FPos2");

                _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
            }
        }
    }

    //called if gameObject in board position 2
    public void _pos2Combat()
    {
        //checking if the unit is friendly
        if (_side == "Friendly")
            {
                //checking for shield bearers
                if (GameObject.Find("EPos2") != null && GameObject.Find("EPos2").tag == "ShieldBearer")
                {
                    GameObject _attacking = GameObject.Find("EPos2");
                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                else if (GameObject.Find("EPos1") != null && GameObject.Find("EPos1").tag == "ShieldBearer")
                {
                    GameObject _attacking = GameObject.Find("EPos1");
                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //standard action if there are no shield bearers
                //asking if an enemy in Position 4 exist
                else if (GameObject.Find("EPos4") != null)
                {
                    GameObject _attacking = GameObject.Find("EPos4");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if an enemy exist in pos 3
                else if (GameObject.Find("EPos3") != null)
                {
                    GameObject _attacking = GameObject.Find("EPos3");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if an enemy exist in pos 2
                else if (GameObject.Find("EPos2") != null)
                {
                    GameObject _attacking = GameObject.Find("EPos2");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if an enemy exist in pos 1
                else if (GameObject.Find("EPos1") != null)
                {
                    GameObject _attacking = GameObject.Find("EPos1");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
            }
            else
            {
            //checking for shield bearers
            if (GameObject.Find("FPos2") != null && GameObject.Find("FPos2").tag == "ShieldBearer")
            {
                GameObject _attacking = GameObject.Find("FPos2");
                _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
            }
            else if (GameObject.Find("FPos1") != null && GameObject.Find("FPos1").tag == "ShieldBearer")
            {
                GameObject _attacking = GameObject.Find("FPos1");
                _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
            }
            //standard action if there are no shield bearers
            //asking if a friend is in Position 4 exist
            else if (GameObject.Find("FPos4") != null)
                {
                    GameObject _attacking = GameObject.Find("FPos4");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if a friend is exist in pos 3
                else if (GameObject.Find("FPos3") != null)
                {
                    GameObject _attacking = GameObject.Find("FPos3");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if a friend is exist in pos 2
                else if (GameObject.Find("FPos2") != null)
                {
                    GameObject _attacking = GameObject.Find("FPos2");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if a friend is exist in pos 1
                else if (GameObject.Find("FPos1") != null)
                {
                    GameObject _attacking = GameObject.Find("FPos1");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
            }
    }

    //called if gameObject in board position 3
    public void _pos3Combat()
    {
            //checking if the unit is friendly
            if (_side == "Friendly")
            {
                //checking for shield bearers
                if (GameObject.Find("EPos3") != null && GameObject.Find("EPos3").tag == "ShieldBearer")
                {
                    GameObject _attacking = GameObject.Find("EPos3");
                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //standard action if there are no shield bearers
                //asking if an enemy in Position 1 exist
                else if (GameObject.Find("EPos1") != null)
                {
                    GameObject _attacking = GameObject.Find("EPos1");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //checking for shield bearers
                else if (GameObject.Find("EPos4") != null && GameObject.Find("EPos4").tag == "ShieldBearer")
                {
                    GameObject _attacking = GameObject.Find("EPos4");
                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //standard action if there are no shield bearers
                //asking if an enemy exist in pos 2
                else if (GameObject.Find("EPos2") != null)
                {
                    GameObject _attacking = GameObject.Find("EPos2");
                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if an enemy exist in pos 3
                else if (GameObject.Find("EPos3") != null)
                {
                    GameObject _attacking = GameObject.Find("EPos3");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if an enemy exist in pos 4
                else if (GameObject.Find("EPos4") != null)
                {
                    GameObject _attacking = GameObject.Find("EPos4");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
            }
            else
            {
                //checking for shield bearers
                if (GameObject.Find("FPos3") != null && GameObject.Find("FPos3").tag == "ShieldBearer")
                {
                    GameObject _attacking = GameObject.Find("FPos3");
                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //standard action if there are no shield bearers
                //asking if a friend is in Position 1 exist
                else if (GameObject.Find("FPos1") != null)
                {
                    GameObject _attacking = GameObject.Find("FPos1");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //checking for shield bearers
                else if (GameObject.Find("FPos4") != null && GameObject.Find("FPos4").tag == "ShieldBearer")
                {
                    GameObject _attacking = GameObject.Find("FPos4");
                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //standard action if there are no shield bearers
                //asking if a friend is exist in pos 2
                else if (GameObject.Find("FPos2") != null)
                {
                    GameObject _attacking = GameObject.Find("FPos2");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if a friend is exist in pos 3
                else if (GameObject.Find("FPos3") != null)
                {
                    GameObject _attacking = GameObject.Find("FPos3");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if a friend is exist in pos 4
                else if (GameObject.Find("FPos4") != null)
                {
                    
                    GameObject _attacking = GameObject.Find("FPos4");
                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
            }
    }

    //called if gameObject in board position 4
    public void _pos4Combat()
    {
            //checking if the unit is friendly
            if (_side == "Friendly")
            {
                //checking for shield bearers
                if (GameObject.Find("EPos4") != null && GameObject.Find("EPos4").tag == "ShieldBearer")
                {
                    GameObject _attacking = GameObject.Find("EPos4");
                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //standard action if there are no shield bearers
                //asking if an enemy in Position 2 exist
                else if (GameObject.Find("EPos2") != null)
                {
                    GameObject _attacking = GameObject.Find("EPos2");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //checking for shield bearers
                else if (GameObject.Find("EPos3") != null && GameObject.Find("EPos3").tag == "ShieldBearer")
                {
                    GameObject _attacking = GameObject.Find("EPos3");
                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //standard action if there are no shield bearers
                //asking if an enemy exist in pos 1
                else if (GameObject.Find("EPos1") != null)
                {
                    GameObject _attacking = GameObject.Find("EPos1");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if an enemy exist in pos 4
                else if (GameObject.Find("EPos4") != null)
                {
                    GameObject _attacking = GameObject.Find("EPos4");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if an enemy exist in pos 3
                else if (GameObject.Find("EPos3") != null)
                {
                    GameObject _attacking = GameObject.Find("EPos3");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
            }
            else
            {
                //checking for shield bearers
                if (GameObject.Find("FPos4") != null && GameObject.Find("FPos4").tag == "ShieldBearer")
                {
                    GameObject _attacking = GameObject.Find("FPos4");
                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //standard action if there are no shield bearers
                //asking if a friend is in Position 2 exist
                else if (GameObject.Find("FPos2") != null)
                {
                    GameObject _attacking = GameObject.Find("FPos2");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //checking for shield bearers
                else if (GameObject.Find("FPos3") != null && GameObject.Find("FPos3").tag == "ShieldBearer")
                {
                    GameObject _attacking = GameObject.Find("FPos3");
                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //standard action if there are no shield bearers
                //asking if a friend is exist in pos 1
                else if (GameObject.Find("FPos1") != null)
                {
                    GameObject _attacking = GameObject.Find("FPos1");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if a friend is exist in pos 4
                else if (GameObject.Find("FPos4") != null)
                {
                    
                    GameObject _attacking = GameObject.Find("FPos4");
                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
                //asking if a friend is exist in pos 3
                else if (GameObject.Find("FPos3") != null)
                {
                    GameObject _attacking = GameObject.Find("FPos3");

                    _attacking.GetComponent<UnitManager_scr>()._health -= _damage;
                }
            }
    }
}
