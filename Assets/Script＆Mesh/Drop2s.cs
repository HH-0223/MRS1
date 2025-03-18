using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop2s : MonoBehaviour
{
    private Rigidbody rb;
    private float time;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        time = 0;
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time > 2)
        {
            rb.isKinematic = false;
        }
    }
}