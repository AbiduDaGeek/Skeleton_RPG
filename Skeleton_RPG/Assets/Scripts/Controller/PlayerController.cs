﻿using UnityEngine.EventSystems;
using UnityEngine;

//Set walkable object in ground layer
[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    //movementMask is used to define in which places player can go
    public LayerMask movementMask;
    //reference to camera, stored in a variable
    Camera cam;
    public Interactable focus;
    PlayerMotor motor;
    // Start is called before the first frame update
    void Start()
    {
        //getting the camera, initialization
        cam = Camera.main ;
        motor = GetComponent<PlayerMotor>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        //Move player to the touch position
        if(Input.GetMouseButton(0))
        {
            //Declaring the ray to be shooted from the cam
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            //declare the variable to store the info, what we hit ?
            RaycastHit hit;
            //cast ray from camera to screen position
            if(Physics.Raycast(ray,out hit, 100, movementMask))
            {
                //move player to what we hit
                motor.MoveToPoint(hit.point);
                //difoucing
                RemoveFocus();
            }
        }
        
        //Focus on Interactive Objects
        if(Input.GetMouseButton(1))
        {
            //Declaring the ray to be shooted from the cam
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            //declare the variable to store the info, what we hit ?
            RaycastHit hit;//cast ray from camera to screen position
            if (Physics.Raycast(ray, out hit, 100))
            {
                //check if the object is interactiveStuff
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                //if so, set it to goal
                if(interactable != null)
                {
                    SetFocus(interactable);
                }
            }
        }
        
    }
void SetFocus (Interactable newFocus)
{
    if (newFocus != focus)
    {
        if(focus != null)
        focus.OnDefocused();
        focus = newFocus;
        motor.FollowTarget(newFocus);
    }
    
    newFocus.OnFocused(transform);
    
}
void RemoveFocus()
{
    if(focus != null)
    focus.OnDefocused();
    focus = null;
    motor.StopFollowingTarget();
}

}
