using UnityEngine;

public class ParticleEffect : MonoBehaviour {

    public ParticleSystem particles;
    public GameObject ImpactEffect;

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            GameObject particle = Instantiate(particles.gameObject, contact.point, Quaternion.LookRotation(contact.normal));
            Destroy(particle, 4f);
        }
    }
}
