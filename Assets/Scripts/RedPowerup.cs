using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPowerup : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem;
    public GameObject Panel;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Panel.SetActive(true);
            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.duration;
            em.enabled = true;
            collisionParticleSystem.Play();
            Invoke(nameof(DestroyObj), dur);
        }
    }
    void DestroyObj()
    {
        Destroy(gameObject);
    }
}
