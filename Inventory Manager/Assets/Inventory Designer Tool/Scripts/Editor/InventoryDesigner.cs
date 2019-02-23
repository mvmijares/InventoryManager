using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class InventoryDesigner : EditorWindow {
    [MenuItem("Window/Inventory Designer")]
    static void OpenWindow() {
        InventoryDesigner window = (InventoryDesigner)GetWindow(typeof(InventoryDesigner));
        window.minSize = new Vector2(600, 300);
        window.Show();
    }
}
