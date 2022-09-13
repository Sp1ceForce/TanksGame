using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public static MenuController Instance { get; private set; }
    [SerializeField] GameObject menuPanel;
    GameObject playerObject;
    private void Start()
    {
        SetupInstance();
        playerObject = StaticHelper.Instance.PlayerObject;
    }

    private void SetupInstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("More than one MenuController!");
        }
    }

    public void PauseGame()
    {
        playerObject.GetComponentInChildren<PlayerTowerRotation>().enabled = false;
        playerObject.GetComponentInChildren<PlayerShoot>().enabled = false;
        playerObject.GetComponentInChildren<BodyRotation>().enabled = false;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }
    public void UnpauseGame()
    {
        playerObject.GetComponentInChildren<PlayerTowerRotation>().enabled = true;
        playerObject.GetComponentInChildren<PlayerShoot>().enabled = true;
        playerObject.GetComponentInChildren<BodyRotation>().enabled = true;
        Cursor.visible = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale==1 && Input.GetButtonDown("MenuButton"))
        { 
            PauseGame();
            menuPanel.SetActive(true);
        }
    }
}
