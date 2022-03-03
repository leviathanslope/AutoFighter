using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomShop_scr : MonoBehaviour
{

    [SerializeField] Sprite _Swordsman;
    [SerializeField] Sprite _spearsman;
    [SerializeField] Sprite _shieldbearer;
    [SerializeField] Sprite _archer;
    [SerializeField] Sprite _mage;
    [SerializeField] Sprite _healer;

    // Start is called before the first frame update
    void Start()
    {
        _generateUnit();
    }

    public void _generateUnit()
    {

        int r = Random.Range(1, 6);

        //is swordsman
        if (r == 1)
        {
            gameObject.tag = "Swordsman";
            gameObject.GetComponent<Image>().sprite = _Swordsman;
        }
        //is spearsman
        if (r == 2)
        {
            gameObject.tag = "Spearman";
            gameObject.GetComponent<Image>().sprite = _spearsman;
        }
        //is shieldbearer
        if (r == 3)
        {
            gameObject.tag = "ShieldBearer";
            gameObject.GetComponent<Image>().sprite = _shieldbearer;
        }
        //is archer
        if (r == 4)
        {
            gameObject.tag = "Archer";
            gameObject.GetComponent<Image>().sprite = _archer;
        }
        // is mage
        if (r == 5)
        {
            gameObject.tag = "Mage";
            gameObject.GetComponent<Image>().sprite = _mage;
        }
        //is healer
        if (r == 6)
        {
            gameObject.tag = "Healer";
            gameObject.GetComponent<Image>().sprite = _healer;
        }

    }
}
