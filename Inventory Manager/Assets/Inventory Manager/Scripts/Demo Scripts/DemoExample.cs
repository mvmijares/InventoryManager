using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DemoScripts {
    public class DemoExample : MonoBehaviour {

        public Item newItem;
        public Inventory inventory;
        public int inventorySize;
        public float destructionTime;
        public bool isCoroutineRunning;
        [SerializeField] private float currentDestructionTime;


        private void Awake() {
            IStackable stackable = newItem as IStackable;
            if(stackable != null) {
                stackable.stackCount = 1;
            }
            isCoroutineRunning = false;

            inventory = new Inventory(inventorySize);
        }
        void DestroyItem() {
            //Testing if the item implements the destructable interface.
            IDestructable destructable = newItem as IDestructable;
         
            if (destructable != null) {
                if (!isCoroutineRunning) {
                    StartCoroutine(DestructionCoroutine());
                }
            }
        }
        //void TestSorting() {
        //    Item item1 = new Item("Helmet", ItemType.Armor);
        //    inventory.Add(item1);
        //    Item item2 = new Item("Breast-Plate", ItemType.Armor);
        //    inventory.Add(item2);
        //    Item item3 = new Item("Gloves", ItemType.Armor);
        //    inventory.Add(item3);
        //    Item item4 = new Item("Scale-Mail", ItemType.Armor);
        //    inventory.Add(item4);

        //    Debug.Log("- Before Sort -");
        //    string itemString1 = "";
        //    foreach (Item i in inventory.items) {
        //        itemString1 += i.itemName + " ";
        //    }
        //    Debug.Log(itemString1);
        //    inventory.SortBy(SortingMethod.Alphabetical);
        //    Debug.Log("After Sort");
        //    string itemString = "";
        //    foreach (Item i in inventory.items) {
        //        itemString += i.itemName + " ";
        //    }
        //    Debug.Log(itemString);
        //}
        IEnumerator DestructionCoroutine() {
            isCoroutineRunning = true;
            yield return new WaitForSeconds(destructionTime);
            Destroy(newItem);
        }
    }
}
