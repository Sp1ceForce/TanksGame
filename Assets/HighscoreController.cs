using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighscoreController : MonoBehaviour
{
    public int Score { get; private set; }
    public int HighScore { get; private set; }
    public bool NewRecord { get; private set; }
    [SerializeField] int scoreForCoins;
    [SerializeField] int timeModifier;
    private void Awake()
    {
        HighScore = PlayerPrefs.GetInt("HighScore");
        Score = 0;
    }
    public void OnCoinPickup()
    {
        Score += scoreForCoins;
    }
    private void FixedUpdate()
    {
        Score += timeModifier;
        if(!NewRecord && Score>HighScore) NewRecord = true;
    }
    public void OnDeath()
    {
        if (NewRecord)
        {
        PlayerPrefs.SetInt("HighScore", Score);
        }
    }
}
