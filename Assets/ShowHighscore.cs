using UnityEngine;
using TMPro;

public class ShowHighscore : MonoBehaviour
{
    void Start()
    {
        GetComponent<TMP_Text>().text = $"Highscore: {PlayerPrefs.GetInt("HighScore")}";
    }
}
