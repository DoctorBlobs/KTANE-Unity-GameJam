using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TimerController : MonoBehaviour { 
    float timeLeft;
    private int maxTime = 30;
    public bool timerOn = false;
    public int seconds = 30;
    public TMP_Text timeText;
    public GameObject gameOverUI;

    void Start()
    {
        timeLeft = maxTime;
         
    }

    void Update()
    {
        if (timerOn){Timer();}
        DisplayTime(timeLeft);
    }

    void Timer(){
        timeLeft -= Time.deltaTime;
        if ( timeLeft <= 0 ){
            gameOverUI.SetActive(true);
            
            timerOn = false;
        }
    }

    void DisplayTime(float timeToDisplay){
        seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{1:00}", 0, seconds);
    }

    public void StartTimer()
    {
        timerOn = true;
    }
}