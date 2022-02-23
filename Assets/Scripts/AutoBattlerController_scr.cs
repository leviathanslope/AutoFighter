using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBattlerController_scr : MonoBehaviour
{
    
    
    int _actionTick;


    // Start is called before the first frame update
    void Start()
    {
        _actionTick = 0;

        //LoadStats();

        getAttributes();
    }
    void LoadStats()
    {

    }
    void getAttributes()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _actionTick++;
        }
    }

}
