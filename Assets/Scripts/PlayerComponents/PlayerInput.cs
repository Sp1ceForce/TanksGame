using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] float speed = 9f;
    Rigidbody2D rb;
    StatsComponent stats;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        stats = StaticHelper.Instance.PlayerStats;
        speed = stats.MovementSpeed;
        stats.OnStatsChange += UpdateStats;
    }
    void UpdateStats()
    {
        speed = stats.MovementSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");
        Vector2 velocity = new Vector2(xInput, yInput).normalized * speed;
        rb.velocity = velocity;
    }
}
