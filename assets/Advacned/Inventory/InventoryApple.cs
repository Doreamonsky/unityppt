using UnityEngine;
[CreateAssetMenu(fileName = "Inventory", menuName = "ScriptableObject/Apple", order = 1)]

public class InventoryApple : Inventory {
    public override void Collect() {
        Debug.Log(string.Format("l am {0} and my weight is {1}","Apple",this.weight));
    }
}
