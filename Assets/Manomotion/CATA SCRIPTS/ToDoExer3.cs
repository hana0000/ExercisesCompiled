using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToDoExer3 : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 90;
    public bool takingAway = false;
    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "Relax!";
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
        if ((secondsLeft) % 9 == 0 || (secondsLeft) %9 > 6)
        {
            textDisplay.GetComponent<Text>().text = "Relax!";
        }else if ((secondsLeft) % 9 > 3)
        {
            textDisplay.GetComponent<Text>().text = "TableFold!";
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "Hold!";
        }
        takingAway = false;
    }
}
