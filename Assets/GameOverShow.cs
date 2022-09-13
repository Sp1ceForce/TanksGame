using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverShow : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    public void OnDeath()
    {
        MenuController.Instance.PauseGame();
        gameOverPanel.SetActive(true);
    }

}
