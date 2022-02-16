using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBattlerController_scr : MonoBehaviour
{

    [SerializeField] GameObject FrontU;
    [SerializeField] GameObject BackLU;
    [SerializeField] GameObject BackRU;
    [SerializeField] GameObject FrontE;
    [SerializeField] GameObject BackLE;
    [SerializeField] GameObject BackRE;

    float FUA;
    float FUH;

    float BLUA;
    float BLUH;

    float BRUA;
    float BRUH;

    float FEA;
    float FEH;

    float BLEA;
    float BLEH;

    float BREA;
    float BREH;

    float actionTick;


    // Start is called before the first frame update
    void Start()
    {
        actionTick = 0;

        getAttributes();
    }

    void getAttributes()
    {
        FUA = FrontU.GetComponent<UnitManager_scr>().attack;
        FUH = FrontU.GetComponent<UnitManager_scr>().health;

        BLUA = BackLU.GetComponent<UnitManager_scr>().attack;
        BLUH = BackLU.GetComponent<UnitManager_scr>().health;

        BRUA = BackRU.GetComponent<UnitManager_scr>().attack;
        BRUH = BackRU.GetComponent<UnitManager_scr>().health;

        FEA = FrontE.GetComponent<UnitManager_scr>().attack;
        FEH = FrontE.GetComponent<UnitManager_scr>().health;

        BLEA = BackLE.GetComponent<UnitManager_scr>().attack;
        BLEH = BackLE.GetComponent<UnitManager_scr>().health;

        BREA = BackRE.GetComponent<UnitManager_scr>().attack;
        BREH = BackRE.GetComponent<UnitManager_scr>().health;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            actionTick++;
        }

        FirstCombat();
        SecondCombat();
    }

    void FirstCombat()
    {
        if (actionTick == 1)
        {
            actionTick = 2;

            FUH -= FEA;
            FEH -= FUA;

            if (FUH <= 0)
            {
                Destroy(FrontU);
            }
            if (FEH <= 0)
            {
                Destroy(FrontE);
            }

        }
    }

    void SecondCombat()
    {
        if (actionTick == 3)
        {
            actionTick = 4;

            BLEH -= BLUA;
            BREH -= BRUA;

            BLUH -= BLEA;
            BRUH -= BREA;

            if (BLEH <= 0)
            {
                Destroy(BackLE);
            }
            if (BREH <= 0)
            {
                Destroy(BackRE);
            }
            if (BLUH <= 0)
            {
                Destroy(BackLU);
            }
            if (BRUH <= 0)
            {
                Destroy(BackRU);
            }

        }
    }
}
