using UnityEngine;

public class InventoryUI : MonoBehaviour
{
	#region Variables
	public Transform itemsParent;
    InventorySlot[] slots;
    Inventory inventory;
    public GameObject inventoryUI;
	//For referencing to UI button
	#endregion
	void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        // may call in Update method if it is Dyamic-^
    }

    void Update()
    {
        
    }
    void UpdateUI()
    {
            for (int i = 0 ; i < slots.Length; i++)
            {
                if (i < inventory.items.Count)
                {
                    slots[i].AddItem(inventory.items[i]);
                }
                else
                {
                    slots[i].ClearSlot();
                }
            }
        
    }
    void CallInventoryUI()
    {

        inventoryUI.SetActive(true);
    }
}
