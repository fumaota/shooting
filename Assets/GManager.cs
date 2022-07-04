using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    private GameObject[] enemy;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);

        Application.targetFrameRate = 60;

        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemy.Length == 0)
        {
            panel.SetActive(true);
        }
    }
}
