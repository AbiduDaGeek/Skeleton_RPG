using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScene : MonoBehaviour
{
    private CanvasGroup fadeGroup;
    private float fadeInSpeed = 0.333f; // 1 Devided by the time we want the transition to take,]
    //here we took 3 sec so 1/3 = 0.33

    void Start()
    {
         fadeGroup = FindObjectOfType<CanvasGroup>(); //Grab the ONLY canavas From the scene
         fadeGroup.alpha = 1; //Start with a white screen
    }

    // Update is called once per frame
    void Update()
    {
        //Fade in
        fadeGroup.alpha = 1- Time.timeSinceLevelLoad * fadeInSpeed ;
    }
}
