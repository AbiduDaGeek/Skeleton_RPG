﻿using UnityEngine;

public class Interactable : MonoBehaviour
{
   public float radius = 6f;
   public Transform interactionTransform;
   bool isFocus = false;
   Transform player;
   bool hasInteracted = false;

public virtual void Interact()
{
   // virtual method can be overwritten
   Debug.Log("Interacted with" + transform.name);
}
   void Update() 
   {
      if (isFocus && !hasInteracted)
      {
         float disatance = Vector3.Distance(player.position, interactionTransform.position);
         if(disatance <= radius)
         {
            Interact();
            hasInteracted = true;
         }
      }
   }

   public void OnFocused(Transform playerTransform) 
   {
      isFocus = true;
      player = playerTransform;
      hasInteracted = false;
      
   }
   public void OnDefocused () 
   {
      isFocus = false ;
      player = null ;
      hasInteracted = false;
      
   }

   private void OnDrawGizmosSelected() 
   {

    Gizmos.color = Color.yellow;
    Gizmos.DrawWireSphere(interactionTransform.position, radius);


   }
  
}