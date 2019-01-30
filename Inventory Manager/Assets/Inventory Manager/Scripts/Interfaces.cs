using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// I use a single file for interfaces because of how small the interfaces are.
/// For coding standards, if your interfaces are large, keep them in seperate files.
/// </summary>

public interface IDestructable {
    void OnItemDestruction();
}

public interface IStackable {
    bool isStackable { get; set; }
    int stackCount { get; set; }
}

public interface IStats {
    int STR { get; set; }
    int DEX { get; set; }
    int STA { get; set; }
    int INT { get; set; }
    int EVA { get; set; }
    int LUK { get; set; }
}
