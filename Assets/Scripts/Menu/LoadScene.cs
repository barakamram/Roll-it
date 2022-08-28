using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private int sceneToLoad;
    public void LoadMenuScene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadNextLevel()
    {
        sceneToLoad = PlayerPrefs.GetInt("NextScene");
        SceneManager.LoadScene(sceneToLoad);
    }
    public void LoadCurrScene()
    {
        sceneToLoad = PlayerPrefs.GetInt("CurrScene");
        SceneManager.LoadScene(sceneToLoad);
    }

}
