using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTowerRotatingComponent : MonoBehaviour
{
    [SerializeField] Transform towerTransform;
    GameObject playerObject;
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObject == null) return;
        float angle = MathHelpers.AngleBetweenPoints(towerTransform.position, playerObject.transform.position);
        towerTransform.rotation = Quaternion.Euler(0, 0, angle + 90f);
    }
}
