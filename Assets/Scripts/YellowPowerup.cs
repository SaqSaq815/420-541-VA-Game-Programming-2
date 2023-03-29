using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPowerup : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            ScoreManager.scoreValue += 50;
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
