using UnityEngine;

public class PlayerTowerRotation : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = MathHelpers.AngleBetweenPoints(transform.position, mousePos);
        transform.rotation = Quaternion.Euler(0, 0, angle + 90f);
    }

}
