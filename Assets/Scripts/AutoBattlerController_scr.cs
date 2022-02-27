using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBattlerController_scr : MonoBehaviour
{
    
    public int _actionTick;


    // Start is called before the first frame update
    void Start()
    {
        _actionTick = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _actionTick++;
        }
        if (_actionTick >= 5)
        {
            _actionTick = 1;
        }
        print(_actionTick);
    }
}
