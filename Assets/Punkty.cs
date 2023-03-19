using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punkty : MonoBehaviour
{
    public Text MyScoreText;
    private int ScoreNum;

    void Start()
    {
        ScoreNum = 0;
        MyScoreText.text = " Punkty :  " + ScoreNum;
    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "MyCoin")
        {
            ScoreNum += 1;
            Destroy(Coin.gameObject);
            MyScoreText.text = " Punkty :  " + ScoreNum;
        }
    }


}