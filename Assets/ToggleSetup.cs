using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSetup : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<Toggle>().isOn = Screen.fullScreen;   
    }
}
