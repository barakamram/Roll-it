using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OnClick : MonoBehaviour
{
    void Start()
	{
		Button button = this.GetComponent<Button>();
		button.onClick.AddListener(LoadOnClick);
		string name = this.GetComponent<Button>().gameObject.name;
    }
   
    void LoadOnClick()
	{
		PlayerPrefs.SetInt("available", 1);
		SceneManager.LoadScene(name);
	}
    
}
