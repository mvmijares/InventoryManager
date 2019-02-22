using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SortingMethod { Alphabetical, StackCount, Qaulity }

public class Inventory : MonoBehaviour {

    public List<ScriptableItem> items; // should be private
    private int _size; // inventorySize
    private int _currentSize;

    public int size {  get { return _size; } }
    public int currentSize { get { return _currentSize; } }

    public Inventory(int size) {
        items = new List<ScriptableItem>();
        _size = size;
    }
    /// <summary>
    /// Get item based on index
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    //public Item GetItem(int index) {
    //    //return items[index];
    //}
    /// <summary>
    /// Add item to inventory
    /// </summary>
    /// <param name="i"></param>
    //public void Add(Item i) {
    //    //items.Add(i);
    //}
    /// <summary>
    /// Generic Inventory Sort
    /// </summary>
    //public void SortBy(SortingMethod method) {
    //    switch (method) {
    //        case SortingMethod.Alphabetical: {
    //                AlphabeticalSort(true);
    //                break;
    //            }
    //    }
    //}

    //private void AlphabeticalSort(bool sort) {
    //    items.Sort(new ItemComparer());
    //}

}
