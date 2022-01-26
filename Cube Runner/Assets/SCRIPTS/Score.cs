using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text finalScoreText;
    public Text finalScoreText1;
    int myscore = 0;

    void Update()
    {
        scoreText.text = myscore.ToString();
        finalScoreText.text = "SCORE : " + myscore.ToString();
        finalScoreText1.text = "SCORE : " + myscore.ToString();
    }

    public void AddScore(int score)
    {
        myscore = myscore + score;
    }
}
