using UnityEngine;

public class ShopCallScript : MonoBehaviour
{
    bool isInside = false;
    ShopPanelController shopController;
    private void Start()
    {
        shopController = GameObject.FindGameObjectWithTag("Shop").GetComponent<ShopPanelController>();
    }
    void Update()
    {
        if (!isInside) return;
        if (Input.GetButtonDown("Interaction"))
        {
            shopController.OpenShop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isInside = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isInside=false;
    }
}
