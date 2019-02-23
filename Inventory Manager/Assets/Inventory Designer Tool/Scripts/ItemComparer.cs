using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// By default, we sort items alphabetically.
/// As the project grows, we can add different ways to sort items
/// </summary>
public class ItemComparer : IComparer<Item> {
    public int Compare(Item x, Item y) {
        return SortByName(x, y);
    }
    private int SortByName(Item x, Item y) {
        return String.Compare(x.itemName, y.itemName);
    }
}