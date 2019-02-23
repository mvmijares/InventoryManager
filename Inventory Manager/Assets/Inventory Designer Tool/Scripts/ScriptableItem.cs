using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventory/Item", order = 1)]
public class ScriptableItem : ScriptableObject {
    public string itemName;
    public ItemType type;
    public Quality quality;

    [TextArea(3, 10), Tooltip("Item description that will show up in the description box.")]
    public string itemDescription;

}
