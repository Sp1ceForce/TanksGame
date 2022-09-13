using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelShow : BaseButtonScript
{
    [SerializeField] GameObject PanelToShow;
    protected override void OnButtonClick()
    {
        PanelToShow.SetActive(true);
    }

}
