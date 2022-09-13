using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashPanel : MonoBehaviour
{
    Text coinCounter;

    private void Start()
    {
        coinCounter = GetComponentInChildren<Text>();
        coinCounter.text = "0";
        StaticHelper.Instance.PlayerObject.GetComponent<PlayersCashComponent>().OnCashUpdate.AddListener(UpdateMoneyCounter);
    }

    public void UpdateMoneyCounter(int money)
    {
        if(money >= 9999999)
        {
            coinCounter.text = "9999999";
            return;
        }
        coinCounter.text = money.ToString();
    }
}
