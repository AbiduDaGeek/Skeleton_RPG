using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerPos : MonoBehaviour
{
    private CheckPointManager cmp;
    void Start()
    {
        cmp = GameObject.FindGameObjectWithTag("CheckPointManager").GetComponent<CheckPointManager>();
        transform.position = cmp.lastCheckPointPos;
    }
    private void Update()
    {
        // Check if died
        if (Input.GetKeyDown(KeyCode.Space))//Died
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
