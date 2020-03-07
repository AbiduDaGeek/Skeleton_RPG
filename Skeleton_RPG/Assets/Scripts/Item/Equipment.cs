using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment",menuName = "Inventory/Equipment")]
public class Equipment : Item
{
    public int armorModifier;
    public int damageModifier;
    public EquipmentSlot epuipSlot;
    public override void Use()
    {
        base.Use();
        //Equip The Item
        EquipmentManager.instance.Equip(this);
        //Remove From Inventory
        RemoveFromInventory();
    }
}

public enum EquipmentSlot {Head,Chest,Arms,Legs,Weapon,Sheild,Feet};
