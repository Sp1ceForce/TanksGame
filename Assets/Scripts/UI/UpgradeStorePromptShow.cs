using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpgradeStorePromptShow : MonoBehaviour
{

    [SerializeField] GameObject promptText;
    void Start()
    {
        promptText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        promptText.gameObject.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        promptText.gameObject.SetActive(false);
    }
}
