using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    private static CheckPointManager instance;
    public Vector3 lastCheckPointPos;
    void Awake()
    {
        if (instance==null)
        {
            instance=this;
            DontDestroyOnLoad(instance);       
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
