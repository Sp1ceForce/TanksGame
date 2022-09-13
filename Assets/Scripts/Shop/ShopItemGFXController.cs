using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemGFXController : MonoBehaviour
{
    ShopItemInfo shopItemInfo;
    TMP_Text descriptionText;
    TMP_Text buyButtonText;
    private void Start()
    {
        shopItemInfo = GetComponent<ShopItemInfo>();
        descriptionText = GetComponentsInChildren<TMP_Text>()[0];
        buyButtonText = GetComponentsInChildren<TMP_Text>()[1];
        UpdateInfo();
    }
    public void UpdateInfo()
    {
        descriptionText.text = shopItemInfo.BaseDescription + shopItemInfo.CurrentPower;
        buyButtonText.text = "Price: " +shopItemInfo.Price;
    }
    public void SetNotAvailable()
    {
        descriptionText.text = "You can't buy this upgrade";
        buyButtonText.text = "Max level";
        GetComponentInChildren<Button>().interactable = false;
    }
}
