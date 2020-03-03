using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;
   public override void Interact()
   {
       base.Interact();
       PickUp();
   }

   void PickUp()
   {
       Debug.Log("PickingUp" + item.name);
       bool wasPckedUp = Inventory.instance.Add(item);
       if(wasPckedUp)
            Destroy(gameObject);
   }
}
