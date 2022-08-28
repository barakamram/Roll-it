using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTime : MonoBehaviour
{
    public static bool firstTime = false;
    
    private void Start()
    {
        
        if (!firstTime)
            PlayerPrefs.SetInt("available", 0);

        else
            PlayerPrefs.SetInt("available", 1);

    }
}
