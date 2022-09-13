using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuRoadMovement : MonoBehaviour
{
    Material roadMaterial;
    [SerializeField] float offsetSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        roadMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        roadMaterial.mainTextureOffset = new Vector2(0,roadMaterial.mainTextureOffset.y+offsetSpeed);
        if (roadMaterial.mainTextureOffset.y <= -1) roadMaterial.mainTextureOffset = new Vector2(0,0);
    }
}
