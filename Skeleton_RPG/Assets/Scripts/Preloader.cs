using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 

public class Preloader : MonoBehaviour
{
   private CanvasGroup fadeGroup; //Get the Fade canvas Group
   private float loadTime;
   private float minimumLogoTime = 3.0f; // minimum Time of the fade scene

   private void Start() 
   {
       fadeGroup = FindObjectOfType<CanvasGroup>(); //Grab the ONLY canavas From the scene
       fadeGroup.alpha = 1; //Start with a white screen
       //Preload the game here
       //Loading assets
       //Loading from server
       if(Time.time < minimumLogoTime)
       {loadTime = minimumLogoTime;}
       else 
       {loadTime = Time.time;}

       
   }

    private void Update()
    {
        // Fade in
        if(Time.time < minimumLogoTime)
        {
            fadeGroup.alpha =  1- Time.time;
        }
        //Fade Out
        if(Time.time > minimumLogoTime && loadTime !=0)
        {
            fadeGroup.alpha = Time.time - minimumLogoTime ; //BugFix
            if (fadeGroup.alpha >= 1)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }

    }
}
