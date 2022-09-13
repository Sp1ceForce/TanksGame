using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class CollectiblesMovement : MonoBehaviour
{
    GameObject playersObject;
    [SerializeField] float lifetime = 15f;
    [SerializeField] float speed = 0.5f;
    float playersPickupRadius;
    Rigidbody2D rb;
    private void Start()
    {
        playersObject = StaticHelper.Instance.PlayerObject;
        playersPickupRadius = StaticHelper.Instance.PlayerStats.PickupRadius;
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifetime);
    }
    private void Update()
    {
        if (playersObject == null) return;
        if (Vector2.Distance(transform.position, playersObject.transform.position) >= playersPickupRadius) return;
        var moveOffset = Vector2.Lerp(transform.position, playersObject.transform.position, speed);
        rb.MovePosition(moveOffset);

    }
}
