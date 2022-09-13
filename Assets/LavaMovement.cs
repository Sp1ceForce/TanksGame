using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float movementMultiplier = 1.000001f;
    Vector3 velocity;
    private void Start()
    {
        velocity = new Vector3(0,movementSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = transform.position + velocity;
        velocity = new Vector3(0, velocity.y * movementMultiplier);
    }
}
