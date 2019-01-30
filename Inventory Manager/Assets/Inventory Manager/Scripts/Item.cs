using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { Armor, Weapon, Consumable, Ingredient }

public class Item : MonoBehaviour {
    public ItemType type;

    [TextArea(3,10), Tooltip("Item description that will show up in the description box.")]
    public string itemDescription;

    [Tooltip("The sprite that will appear in the inventory.")]
    public Sprite sprite;
    
    public virtual void Update() { }
    public virtual void DestroyItem() {
        Destroy(this.gameObject);
    }
}
