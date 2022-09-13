using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    protected virtual void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }

    protected abstract void OnButtonClick();    
}
