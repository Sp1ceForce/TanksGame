using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButtonScript : BaseButtonScript
{
    protected override void OnButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}
