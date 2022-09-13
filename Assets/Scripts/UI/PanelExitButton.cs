using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelExitButton : BaseButtonScript
{
    protected override void OnButtonClick()
    {
        gameObject.transform.parent.gameObject.SetActive(false);
    }
}
