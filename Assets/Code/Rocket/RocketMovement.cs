using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    Rocket _rocket;

    public void Ñonstruct(Rocket rocket)
    {
        _rocket = rocket;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.LookAt(_rocket.EnemyBody.position);

        _rocket.RocketRB.AddRelativeForce(Vector3.forward * speed, ForceMode.Force);


    }

   
}
