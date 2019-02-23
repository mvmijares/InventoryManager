using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    public static InventoryManager instance = null; // singleton

    [SerializeField] List<ItemUI> itemButtons;

    public Dictionary<string, Sprite> imageLibrary;
    
    public Sprite transparentBox; // Empty inventory slot;
    public InventoryUI inventoryUserInterface;
    public InputManager input; // Need to make this a serialized object
    public Inventory mainInventory; // the main inventory we display to the screen

    private void Awake() {
        if(instance == null) {
            instance = this;
            InitializeInventoryManager();
        } else {
            Destroy(this.gameObject);
        }
    }

    void InitializeInventoryManager() {
        imageLibrary = new Dictionary<string, Sprite>();
        UnityEngine.Object[] images = Resources.LoadAll("Sprites", typeof(Sprite));
        foreach(UnityEngine.Object o in images) {
            Debug.Log(o.name);
            imageLibrary.Add(o.name, o as Sprite);
        }

        itemButtons = new List<ItemUI>();
        ItemUI[] userInterfaceObjects = FindObjectsOfType<ItemUI>();
        foreach(ItemUI ui in userInterfaceObjects) {
            itemButtons.Add(ui);
        }

        inventoryUserInterface = FindObjectOfType<InventoryUI>();
        if(inventoryUserInterface)
            input.OnInventoryPress += inventoryUserInterface.OnInventoryPress;

        if (mainInventory) {
            //foreach(Item i in mainInventory.items) {
            //    inventoryUserInterface.CreateNewItemSlot();
            //}
        }
    }
    private void OnDestroy() {
        if(inventoryUserInterface)
            input.OnInventoryPress -= inventoryUserInterface.OnInventoryPress;
    }

    public Sprite GetSprite(string key) {
        if (imageLibrary.ContainsKey(key)) {
            return imageLibrary[key];
        } else
            return null;
    }
}
