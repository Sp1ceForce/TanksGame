using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWallTrigger : MonoBehaviour
{
    [SerializeField] BoxCollider2D invisibleWall;
    private void Start()
    {
        invisibleWall.isTrigger = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
        invisibleWall.isTrigger = false;

        }
    }
}
