using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyparticle : MonoBehaviour
{
    ParticleSystem explosion;
    
    void Start()
    {
        explosion = GetComponent<ParticleSystem>(); 
    }
    void Update()
    {
        Destroy(gameObject, explosion.main.duration);
    }
}
