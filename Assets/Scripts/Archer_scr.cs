using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer_scr : MonoBehaviour
{
    public float damage = 3;
    public float health = 1;

    string _side;
    int _boardPos;

    // Start is called before the first frame update
    void Start()
    {
        _boardPos = gameObject.GetComponent<UnitManager_scr>()._boardPos;
        _side = gameObject.GetComponent<UnitManager_scr>()._side;
    }

    //called if gameObject in board position 1
    public void _pos1Combat()
    {
        //checking if the unit is friendly
        if (_side == "Friendly")
        {
            //asking if an enemy in Position 3 exist
            if (GameObject.Find("EPos3") != null)
            {
                


            }
            //asking if an enemy exist in pos 4
            else if (GameObject.Find("EPos4") != null)
            {

            }
            //asking if an enemy exist in pos 1
            else if (GameObject.Find("EPos1") != null)
            {

            }
            //asking if an enemy exist in pos 2
            else if (GameObject.Find("EPos2") != null)
            {

            }
        }
        else
        {
            //asking if an enemy in Position 3 exist
            if (GameObject.Find("FPos3") != null)
            {

            }
            //asking if an enemy exist in pos 4
            else if (GameObject.Find("FPos4") != null)
            {

            }
            //asking if an enemy exist in pos 1
            else if (GameObject.Find("FPos1") != null)
            {

            }
            //asking if an enemy exist in pos 2
            else if (GameObject.Find("FPos2") != null)
            {

            }
        }
    }

    //called if gameObject in board position 2
    public void _pos2Combat()
    {
        //asking if an enemy in Position 4 exist
        if (GameObject.Find("EPos4") != null)
        {

        }
        //asking if an enemy exist in pos 3
        else if (GameObject.Find("EPos3") != null)
        {

        }
        //asking if an enemy exist in pos 2
        else if (GameObject.Find("EPos2") != null)
        {

        }
        //asking if an enemy exist in pos 1
        else if (GameObject.Find("EPos1") != null)
        {

        }
    }

    //called if gameObject in board position 3
    public void _pos3Combat()
    {
        //asking if an enemy in Position 1 exist
        if (GameObject.Find("EPos1") != null)
        {

        }
        //asking if an enemy exist in pos 2
        else if (GameObject.Find("EPos2") != null)
        {

        }
        //asking if an enemy exist in pos 3
        else if (GameObject.Find("EPos3") != null)
        {

        }
        //asking if an enemy exist in pos 4
        else if (GameObject.Find("EPos4") != null)
        {

        }
    }

    //called if gameObject in board position 4
    public void _pos4Combat()
    {
        //asking if an enemy in Position 2 exist
        if (GameObject.Find("EPos2") != null)
        {

        }
        //asking if an enemy exist in pos 1
        else if (GameObject.Find("EPos1") != null)
        {

        }
        //asking if an enemy exist in pos 4
        else if (GameObject.Find("EPos4") != null)
        {

        }
        //asking if an enemy exist in pos 3
        else if (GameObject.Find("EPos3") != null)
        {

        }
    }
}
