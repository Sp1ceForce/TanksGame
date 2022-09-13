using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBodyRotatingComponent : MonoBehaviour
{
    [SerializeField] Transform bodyTransform;
    [SerializeField] float rotationSpeed = 0.25f;
    public void RotateBody(Vector3 direction)
    {
        float angle = MathHelpers.AngleBetweenPoints(bodyTransform.position, direction + bodyTransform.position)+ 90;
        float LerpedAngle = Mathf.Lerp(bodyTransform.rotation.z, angle, rotationSpeed);
        bodyTransform.rotation = Quaternion.Euler(bodyTransform.rotation.x, bodyTransform.rotation.y, LerpedAngle);
        
    }
}
