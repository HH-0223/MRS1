using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroyParticle", 2.0f);
    }

    void DestroyParticle()
    {
        Destroy(gameObject);
    }
}