using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MathHelpers 
{
    public static float AngleBetweenPoints(Vector3 a, Vector3 b) { return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg; }
}
