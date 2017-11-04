using UnityEngine;
[CreateAssetMenu(fileName = "Inventory", menuName = "ScriptableObject/Bag", order = 1)]

public class InventoryBag : Inventory {
    public override void Collect() {
        Debug.Log(string.Format("l am {0} and my weight is {1}", "Bag", this.weight));
    }
}
