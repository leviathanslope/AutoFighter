using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager_scr : MonoBehaviour
{

    public int _boardPos;
    public string _side;

    // Start is called before the first frame update
    void Start()
    {
        _sideDeclaration();
        _boardPosDeclaration();
        //print(gameObject.name + ",   Position is: " + _boardPos +  ", unit is:" + _side);
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
            }
            if (transform.position.x > 0 && transform.position.y < 1.5)
            {
                _boardPos = 2;
            }
            if (transform.position.x < 0 && transform.position.y > 1.5)
            {
                _boardPos = 3;
            }
            if (transform.position.x > 0 && transform.position.y > 1.5)
            {
                _boardPos = 4;
            }
        }

        if (_side == "Friendly")
        {
            if (transform.position.x < 0 && transform.position.y > -1.5)
            {
                _boardPos = 1;
            }
            if (transform.position.x > 0 && transform.position.y > -1.5)
            {
                _boardPos = 2;
            }
            if (transform.position.x < 0 && transform.position.y < -1.5)
            {
                _boardPos = 3;
            }
            if (transform.position.x > 0 && transform.position.y < -1.5)
            {
                _boardPos = 4;
            }
        }
    }
}
