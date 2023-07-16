using UnityEngine;

public class RocketHit : MonoBehaviour
{
    Rocket _rocket;

    public void Ñonstruct(Rocket rocket)
    {
        _rocket = rocket;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.GetComponent<Rigidbody>().gameObject == _rocket.EnemyBody.gameObject)
        {
            ProduceHit();
        }
    }

    private void ProduceHit()
    {
        _rocket.EnemyHealth.GetDamage(transform.position);

        _rocket.ExplosionEffectPrefab.SetActive(true);
        _rocket.ExplosionEffectPrefab.GetComponent<ParticleSystem>().Play();

        _rocket.FireStreamEffectPrefab.GetComponent<ParticleSystem>().Stop();
        _rocket.RocketRB.isKinematic = true; //is Kinematic to disable movement after hit
        _rocket.RocketModel.SetActive(false);

        Destroy(gameObject, 3f); //destroy after 5 sec to play effct

    }
}
