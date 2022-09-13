using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    Transform playerTransform;
    void Start()
    {
        playerTransform = StaticHelper.Instance.PlayerObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform == null) return;
        transform.position = new Vector3(0, playerTransform.position.y, 0);
    }
}
