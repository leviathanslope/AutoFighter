using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBearer_scr : MonoBehaviour
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
    }
}
