using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscorePanel : MonoBehaviour
{
    HighscoreController highscoreController;
    Text ScoreText;
    Text HighscoreText;
    void Start()
    {
        var TextArr = GetComponentsInChildren<Text>();
        ScoreText = TextArr[1];
        HighscoreText = TextArr[3];
        highscoreController = GetComponent<HighscoreController>();
        HighscoreText.text = highscoreController.HighScore.ToString();
        ScoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = highscoreController.Score.ToString();
        if (highscoreController.NewRecord) HighscoreText.text = highscoreController.Score.ToString();
    }
}
