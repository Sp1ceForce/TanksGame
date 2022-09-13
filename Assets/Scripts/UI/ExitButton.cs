using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : BaseButtonScript
{
    protected override void OnButtonClick()
    {
        Application.Quit();
    }
}
