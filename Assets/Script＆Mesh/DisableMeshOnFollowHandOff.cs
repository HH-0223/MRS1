using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMeshOnFollowHandOff : MonoBehaviour
{
    public GameObject meshObject;

    public void OnFollowHandToggled(bool isFollowingHand)
    {
        if (!isFollowingHand)
        {
            MeshRenderer renderer = meshObject.GetComponent<MeshRenderer>();
            if(renderer != null)
            {
                renderer.enabled = false;
            }
        }
    }
}
