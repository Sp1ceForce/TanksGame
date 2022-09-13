using UnityEngine;
using TMPro;
public class ShowScore : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<TMP_Text>().text=FindObjectOfType<HighscoreController>().Score.ToString();    
    }
}
