using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject timerDisplay;
    public int timeLeft = 10;
    public bool takingAway = false;

    private void Start()
    {
        timerDisplay.GetComponent<Text>().text = "0" + timeLeft;
    }

    private void Update()
    {
        if (takingAway = false && timeLeft > 0 )
        {
            StartCoroutine(TimerCount()); 
        }
    }
    //start coroutine (timer) 
    IEnumerator TimerCount()
    {
        //takes time away 
        takingAway = true; 
        yield return new WaitForSeconds(1);
        timeLeft -= 1;
        timerDisplay.GetComponent<Text>().text = "0" + timeLeft; 
        takingAway = false;

    }
        

       

}