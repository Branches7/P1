using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;


    public Text scoreText;
    public Text highScoreText;

    int highScorePoints;


    void Awake ()
    {
        score = 0;
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScorePoints = PlayerPrefs.GetInt("HighScore");
        }
    }


    void Update ()
    {
        if(score > highScorePoints)
        {
            highScorePoints = score;
            PlayerPrefs.SetInt("HighScore", highScorePoints);
        }
        scoreText.text = "Score " + score;
        highScoreText.text = "High Score " + highScorePoints;
    }
}
