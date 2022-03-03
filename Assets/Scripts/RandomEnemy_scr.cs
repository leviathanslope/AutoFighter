using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemy_scr : MonoBehaviour
{

    [SerializeField] GameObject _Swordsman;
    [SerializeField] GameObject _spearsman;
    [SerializeField] GameObject _shieldbearer;
    [SerializeField] GameObject _archer;
    [SerializeField] GameObject _mage;
    [SerializeField] GameObject _healer;

    [SerializeField] Sprite _Sw;
    [SerializeField] Sprite _sp;
    [SerializeField] Sprite _sh;
    [SerializeField] Sprite _ar;
    [SerializeField] Sprite _ma;
    [SerializeField] Sprite _he;

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
            GameObject spawn =  Instantiate(_Swordsman, gameObject.transform.localPosition, Quaternion.Euler(0,0,0));
            spawn.GetComponent<SpriteRenderer>().sprite = _Sw;

        }
        //is spearsman
        if (r == 2)
        {
            GameObject spawn = Instantiate(_spearsman, gameObject.transform.localPosition, Quaternion.Euler(0, 0, 0));
            spawn.GetComponent<SpriteRenderer>().sprite = _sp;
        }
        //is shieldbearer
        if (r == 3)
        {
            GameObject spawn = Instantiate(_shieldbearer, gameObject.transform.localPosition, Quaternion.Euler(0, 0, 0));
            spawn.GetComponent<SpriteRenderer>().sprite = _sh;
        }
        //is archer
        if (r == 4)
        {
            GameObject spawn = Instantiate(_archer, gameObject.transform.localPosition, Quaternion.Euler(0, 0, 0));
            spawn.GetComponent<SpriteRenderer>().sprite = _ar;
        }
        // is mage
        if (r == 5)
        {
            GameObject spawn = Instantiate(_mage, gameObject.transform.localPosition, Quaternion.Euler(0, 0, 0));
            spawn.GetComponent<SpriteRenderer>().sprite = _ma;
        }
        //is healer
        if (r == 6)
        {
            GameObject spawn = Instantiate(_healer, gameObject.transform.localPosition, Quaternion.Euler(0, 0, 0));
            spawn.GetComponent<SpriteRenderer>().sprite = _he;
        }

    }
}
