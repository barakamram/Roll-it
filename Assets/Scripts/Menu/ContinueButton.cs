using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ContinueButton : MonoBehaviour
{
    [SerializeField] private Button Continue;
    [SerializeField] private Button Stage;

    private static int available;
    private void Start()
    {
        available = PlayerPrefs.GetInt("available");
        
        if (available == 0)
        {
            Continue.gameObject.SetActive(false);
            Stage.gameObject.SetActive(false);
            FirstTime.firstTime = true;
        }
           
        else if (available == 1)
        {
            Continue.gameObject.SetActive(true);
            Stage.gameObject.SetActive(true);
        }
          
    }
}
