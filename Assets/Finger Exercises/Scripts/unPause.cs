using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unPause : MonoBehaviour
{
    public GameObject alert;

    public void resumeGame()
    {
        Time.timeScale = 1; // unpause game
        alert.SetActive(false);
    }
}
