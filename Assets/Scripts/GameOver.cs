using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI secretWordText;
    
    public List<string> words = new List<string>();

    string secretWord = "hello";

    void Start()
    {
        secretWord = words[Random.Range(0, words.Count - 1)];

        secretWordText.text = secretWord;
    }
}   