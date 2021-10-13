using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerExer3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textDisplay;
    public int secondsLeft = 90;
    public bool takingAway = false;
    public string levelToLoad;

    void Start()
    {
        textDisplay.GetComponent<Text>().text = "01:30";
    }

    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
        if (secondsLeft == 0)
        {
            NextScene();
        }

        IEnumerator TimerTake()
        {
            int minutes = secondsLeft - 61;
            takingAway = true;
            yield return new WaitForSeconds(1);
            secondsLeft -= 1;
            if (secondsLeft < 10)
            {
                textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft;
            }
            else if (secondsLeft < 60)
            {
                textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
            }
            else if (secondsLeft < 70)
            {
                textDisplay.GetComponent<Text>().text = "01:0" + minutes;
            }
            else if (secondsLeft < 90)
            {
                textDisplay.GetComponent<Text>().text = "01:" + minutes;
            }
            takingAway = false;
        }
    }
    void NextScene()
    {
        if (secondsLeft == 0)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
