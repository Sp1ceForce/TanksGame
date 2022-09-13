
using DG.Tweening;
using UnityEngine;

public class BodyRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 0.05f;
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");
        if(xInput !=0 || yInput != 0)
        {
            Vector3 move = new Vector3 (xInput, yInput, 0);
            float angle = MathHelpers.AngleBetweenPoints(transform.position, move+transform.position)+90;
            Quaternion desired = Quaternion.Euler(transform.rotation.x,transform.rotation.y,angle);
            transform.rotation = Quaternion.Lerp(transform.rotation,desired,rotationSpeed);
        }
    }
}
