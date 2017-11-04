using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Inventory", menuName = "ScriptableObject/Inventory", order = 1)]
public abstract class Inventory : ScriptableObject,ICollectable {
    public int weight;

    public abstract void Collect();
}
