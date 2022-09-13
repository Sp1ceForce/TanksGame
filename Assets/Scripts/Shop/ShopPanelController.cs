using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPanelController : MonoBehaviour
{
    [SerializeField] GameObject shopPanel;
    GameObject playerObject;
    private void Start()
    {
        playerObject = StaticHelper.Instance.PlayerObject; 
       
    }
    public void OpenShop()
    {
        shopPanel?.SetActive(true);
        MenuController.Instance.PauseGame();
    }
    public void CloseShop()
    {
        shopPanel?.SetActive(false);
        MenuController.Instance.UnpauseGame();
    }
}
