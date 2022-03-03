using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRandomizer : MonoBehaviour
{
    public List<GameObject> obj1;
    public List<GameObject> obj2;
    public int[] table = { 30, 25, 20, 15, 10}; //Most to least frequent.

    public int total;
    public int randomNum1;
    public int randomNum2;

    private void Start()
    {
        // Checking random number with what item it correlates with.
        // Calculate total from the given table nums.
        foreach (var item in table)
        {
            total += item;
        }
        
        randomNum1 = Random.Range(0, total);
        randomNum2 = Random.Range(0, total);
        Debug.Log("Random Number1: " + randomNum1);
        Debug.Log("Random Number2: " + randomNum2);

        checkRandomNum(obj1, randomNum1);
        checkRandomNum(obj2, randomNum2);
    }

    void checkRandomNum(List<GameObject> obj, int randomNum)
    {
        for (int i = 0; i < table.Length; i++)
        {
            // Compare if randomNum is <= to the current weight.
            if (randomNum <= table[i])
            {
                // Award Item 1.
                Debug.Log("Award: " + table[i]);
                obj[i].SetActive(true);
                return;
            }
            else
            {
                randomNum -= table[i];
            }
        }
    }
    
}
