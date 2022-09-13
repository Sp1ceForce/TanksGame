using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    GameObject playerObject;
    [SerializeField] float cameraSpeed = 0.2f;
    [SerializeField] Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObject == null) return;
        transform.DOMove(new Vector3(transform.position.x, playerObject.transform.position.y,transform.position.z)+offset,cameraSpeed);
    }
}
