using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmet : Item, IStackable, IStats, IDestructable {

    public bool isStackable { get; set; }
    public int stackCount { get; set; }

    public int STR { get; set; }
    public int DEX { get; set; }
    public int STA { get; set; }
    public int INT { get; set; }
    public int EVA { get; set; }
    public int LUK { get; set; }

    public override void Update() {
        base.Update();

        if(stackCount <= 0) {
            OnItemDestruction();
        }
    }
    
    public void OnItemDestruction() {
        DestroyItem();
    }
}
