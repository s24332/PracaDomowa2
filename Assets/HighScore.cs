using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text displayText;

    public void DisplayText()
    {
        displayText.text = "What ever you want to display";
    }
}
