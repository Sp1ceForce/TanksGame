using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementComponent : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float shootingRadiusInset = 1;
    EnemyStats stats;
    GameObject playerObject;
    EnemyBodyRotatingComponent bodyRotatingComponent;
    Rigidbody2D rb;
    void Start()
    {
        stats = GetComponent<EnemyStats>();
        playerObject = StaticHelper.Instance.PlayerObject;
        bodyRotatingComponent = GetComponent<EnemyBodyRotatingComponent>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObject == null) return;
        Vector2 direction = Vector2.zero; 
        if(Vector2.Distance(transform.position,playerObject.transform.position) < stats.AgroRadius)
        {
            if(Vector2.Distance(transform.position, playerObject.transform.position) >= stats.ShootingRadius- shootingRadiusInset)
            {
                Vector2 heading = playerObject.transform.position - transform.position;
                float distance = heading.magnitude;
                direction = heading / distance;
                bodyRotatingComponent.RotateBody(direction);
            }
        }
        rb.velocity = direction * movementSpeed;
    }
}
