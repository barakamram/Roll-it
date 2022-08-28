using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartLevelWithKey : MonoBehaviour
{
    [SerializeField] KeyCode restart;
    void FixedUpdate()
    {
        if (Input.GetKey(restart)) 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
