using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProgressBar : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject final;
    private Image progressBar;
    private float max;
    // Start is called before the first frame update
    void Start()
    {
        progressBar = GetComponent<Image>();
        max = final.transform.position.z;
        progressBar.fillAmount = player.transform.position.z / max;

    }

    // Update is called once per frame
    void Update()
    {
        if (progressBar.fillAmount < 1)
            progressBar.fillAmount = player.transform.position.z / max;
    }
}
