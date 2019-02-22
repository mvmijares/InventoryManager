using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { Armor, Weapon, Consumable, Ingredient }
public enum Quality { Common, Uncommon, Rare, Legendary }

public class Item : MonoBehaviour {

    public string itemName;
    public ItemType type;
    public Quality quality;

    [TextArea(3,10), Tooltip("Item description that will show up in the description box.")]
    public string itemDescription;

    [Tooltip("The sprite that will appear in the inventory.")]
    public Sprite sprite;

    public virtual event Action<Item> ItemInformationEvent;

    public Item(string name, ItemType type) {
        itemName = name;
        this.type = type;
    }
    public virtual void Update() {
        
    }
    public virtual void DestroyItem() {
        Destroy(this.gameObject);
    }
}
