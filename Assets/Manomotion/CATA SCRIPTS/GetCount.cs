using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetCount : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public TextMeshProUGUI summary;

    void Update()
    {
        int receivedCount = TriggerGizmo.countingGesture - 1;
        textDisplay.text = "" + receivedCount;
        if (receivedCount >= 10 && receivedCount <= 16)
        {
            summary.text = "Nice Job!";
        }
        else if (receivedCount <= 9)
        {
            summary.text = "Please Follow the Gesture Properly!";
        }
        else if (receivedCount >= 17)
        {
            summary.text = "Please Slow Down!";
        }
    }
}
