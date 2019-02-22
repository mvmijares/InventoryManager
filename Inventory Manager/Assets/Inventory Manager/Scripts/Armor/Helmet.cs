using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmet : Item, IStats, IDestructable {

    public int STR { get; set; }
    public int DEX { get; set; }
    public int STA { get; set; }
    public int INT { get; set; }
    public int EVA { get; set; }
    public int LUK { get; set; }

    public Helmet(string name, ItemType type) : base(name, type) {

    }
    public override void Update() {
        base.Update();
    }
    
    public void OnItemDestruction() {
        DestroyItem();
    }
}
