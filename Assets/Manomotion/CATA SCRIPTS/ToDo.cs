﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToDo : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 120;
    public bool takingAway = false;
    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "Hold!";
    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if ((secondsLeft) % 12 == 0 || (secondsLeft) % 12 > 6)
        {
            textDisplay.GetComponent<Text>().text = "Hold!";
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "Relax!";
        }
        takingAway = false;
    }
}
