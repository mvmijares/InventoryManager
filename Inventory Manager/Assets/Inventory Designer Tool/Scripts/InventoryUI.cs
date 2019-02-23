using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour {
    public GameObject userInterfaceObject;
    public Sprite emptyItem;
    public Transform contentBox;
    public GameObject itemPrefab;

    private void Awake() {

        if(userInterfaceObject == null) {
            Debug.Log("Did not set interface object");
        }
    }

    public void OnInventoryPress() {
        userInterfaceObject.SetActive(!userInterfaceObject.activeSelf);
    }

    public GameObject CreateNewItemSlot() {
        GameObject clone = Instantiate(itemPrefab);
        clone.transform.SetParent(contentBox);
        return clone;
    }
}
