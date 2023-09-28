using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    internal static float deltaTime;
    public bool timerOn;
    public float timeLeft = 10f;

    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {

                timeLeft = 0;
                timerOn = false;

                SceneManager.LoadScene(1);
            }
        }
    }
}