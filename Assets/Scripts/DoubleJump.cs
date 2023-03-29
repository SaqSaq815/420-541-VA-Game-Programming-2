using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.duration;
            em.enabled = true;
            collisionParticleSystem.Play();
            Invoke(nameof(DestroyObj), dur);

            Debug.Log("collected1");
        }
    }
    void DestroyObj()
    {
        Destroy(gameObject);
    }





}
