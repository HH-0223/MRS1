using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDrop : MonoBehaviour
{
    public GameObject ball;
    private float count = 1.0f;

    void Update()
    {
        count -= Time.deltaTime;
        if (count <= 0)
        {
            Instantiate(ball, new Vector3(0, 5, 0), Quaternion.identity);
            count = 1.0f;
        }
    }
}