﻿using UnityEngine;

//Blue print for all scriptable object in the game
[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
  new public string name = "New Item";
  public Sprite icon = null;
  public bool isDefaultItem = false;
}
