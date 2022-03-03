using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    public Text inventoryNotif;

    public void addItem()
    {
        inventoryNotif.text = this.name + " was added to inventory.";
        gameObject.SetActive(false);
    }
}
