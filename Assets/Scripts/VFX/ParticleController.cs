using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    ParticleSystem pSystem;
    Rigidbody2D rb;
    private void Start()
    {
        pSystem = GetComponent<ParticleSystem>();
        rb = GetComponentInParent<Rigidbody2D>();
    }
    private void Update()
    {
        if((rb.velocity.magnitude!=0))
        {
            if (!pSystem.isEmitting)
            {
                pSystem.Play();
            }
        }
        else if(pSystem.isEmitting) pSystem.Stop(true,ParticleSystemStopBehavior.StopEmitting);
    }
}
