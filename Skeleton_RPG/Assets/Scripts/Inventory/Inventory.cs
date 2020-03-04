using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region SingleToon
    
    public static Inventory instance; //Singelton method
    void Awake() 
    {
        if (instance != null)
        {
             Debug.Log("Multiple Inventory Instance Found");
             return;
        }
        instance = this;
    }
    #endregion
   public delegate void OnItemChanged(); //Study Delegate
   public OnItemChanged onItemChangedCallback;
   public int space = 20;
   public List<Item> items = new List<Item>();
   public bool Add (Item item)
   {
       if(!item.isDefaultItem)
       {
        if(items.Count >= space)
        {
            Debug.Log("Not Enough Space");
            return false;
        }
        items.Add(item);
        if(onItemChangedCallback != null)
            onItemChangedCallback.Invoke(); //Triggering the Event
       }
       return true;
   }
   public void Remove (Item item)
   {
       items.Remove(item);
       if(onItemChangedCallback != null)
            onItemChangedCallback.Invoke(); //Triggering the Event
   }
}
