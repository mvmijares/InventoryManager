using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {


    public event Action OnInventoryPress;
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyUp(KeyCode.I)) {
            if (OnInventoryPress != null) // Event Call for input
                OnInventoryPress();
        }
    }
}
