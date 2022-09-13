using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : BaseButtonScript
{
    protected override void OnButtonClick()
    {
        MenuController.Instance.UnpauseGame();
        transform.parent.gameObject.SetActive(false);
    }
}
