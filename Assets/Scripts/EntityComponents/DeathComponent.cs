using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Component that destroys object and spawns an explosion
public class DeathComponent : MonoBehaviour
{
    [SerializeField] GameObject explosionParticles;
   public void OnDeath()
    {
        if(explosionParticles != null)
        {
        GameObject particles = Instantiate(explosionParticles,transform.position,Quaternion.identity);
        Destroy(particles, 2);
        }
        Destroy(gameObject);

    }
}
