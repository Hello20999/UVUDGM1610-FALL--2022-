using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoretext;
    public void IncreaseScore(int ammount)
    {
        score += ammount;
        UpdateScoreText();
    }
    public void DecreaseScore(int ammount)
    {
        score -= ammount;
        UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        scoretext.text = "score: " + score;
    }
}
