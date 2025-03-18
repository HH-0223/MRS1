using UnityEngine;

public class DebrisDust : MonoBehaviour
{
    public ParticleSystem dust;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            dust.Play();
        }
    }
}
