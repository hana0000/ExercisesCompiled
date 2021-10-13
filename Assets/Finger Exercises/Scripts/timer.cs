using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class timer : MonoBehaviour
{
    public float timeValue = 84f; // 10 reps
    public Text timerText;
    public Text instruction;

    public GameObject alert;
    private Vector3 prevPosition = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(changeText());
        Time.timeScale = 1; // start game
    }

    IEnumerator changeText()
    {
        while (timeValue > 0)
        {
            instruction.text = "Press and hold finger";
            yield return new WaitForSeconds(4);

            instruction.text = "Lift finger";     
            yield return new WaitForSeconds(4); 

        }

        if (timeValue == 0)
        {
            instruction.text = "Exercise Completed!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        displayTime(timeValue);

        // alert
        if (Input.mousePosition != prevPosition)
        {
            ShowAlertInvoke();
            prevPosition = Input.mousePosition;
        }
    }

    void displayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // alert
    void ShowAlertInvoke()
    {
        CancelInvoke();
        Invoke("displayAlert", 8);
    }

    void displayAlert()
    {
        Time.timeScale = 0; // pause game
        alert.SetActive(true);

    }
}
