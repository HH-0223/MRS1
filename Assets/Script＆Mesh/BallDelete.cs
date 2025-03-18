using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDelete : MonoBehaviour
{
    void Update()
    {
        if (this.transform.position.y < -0.06)
        {
            Destroy(gameObject);
        }
    }
}
