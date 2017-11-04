using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventroyDebug : MonoBehaviour {
    public Inventory[] listOfInventroy;

    private void Start() {
        for (int i = 0; i < listOfInventroy.Length;i++){
            listOfInventroy[i].Collect();
        }
    }
}
