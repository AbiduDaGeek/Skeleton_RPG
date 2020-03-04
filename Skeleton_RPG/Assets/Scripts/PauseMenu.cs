﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
        if(GameIsPaused)
        {
           Resume();
           // Debug.Log("Quit!!");
           //Application.Quit();
        }
        else 
        {
             Pause();
        }
        
        }
              
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused =true;

    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu"); //Name of the menu scene should be Match
    }
    public void Quit()
    {
        Debug.Log("Quit!!");
        Application.Quit();
    }


}
