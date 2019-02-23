using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour {

    public Item item; // reference to item
    Button button;
    public void Start() {
        button = GetComponent<Button>();
    }

    private void Update() {
        if (item) {
            button.GetComponent<Image>().sprite = InventoryManager.instance.GetSprite(item.itemName);
        } else {
            button.GetComponent<Image>().sprite = InventoryManager.instance.inventoryUserInterface.emptyItem;
        }
    }
}
