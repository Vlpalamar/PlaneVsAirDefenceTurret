using UnityEngine;

public class PlaneAttack : MonoBehaviour
{
    #region
    [Space(5)]
    [Header("RocketDetails")]
    #endregion
    [SerializeField] private Rocket rocketPrefab;
    [SerializeField] private Transform rocketSpawnrPosition;

    #region
    [Space(5)]
    [Header("OverlapDetails")]
    #endregion
    [SerializeField] private Transform overlapCenterPosition;
    [SerializeField] private float overlapRadius;
    [SerializeField] private float timeToCheckOverlap = 0.3f;

    private Rigidbody enemy;
    private Plane _plane;
    private float timer = 0;

    private void Start()
    {
        _plane = GetComponent<Plane>();
    }
    private void Update()
    {
        if (enemy != null) return;

        timer += Time.deltaTime;
        if (timer >= timeToCheckOverlap)
        {
            TryToSpotEnemy();
            timer = 0;
        }
    }

    private void TryToSpotEnemy()
    {
        Collider[] hitColliders = Physics.OverlapSphere(overlapCenterPosition.position, overlapRadius);
        if (hitColliders.Length > 0)
        {

            foreach (Collider collider in hitColliders)
            {
                if (collider.gameObject == gameObject) continue;

                if (collider.GetComponent(typeof(IDamageble)))
                {
                    print(collider);

                    SpotTheEnemy(collider);
                    Attack();
                    return;
                }
            }
        }
    }
 

    private void SpotTheEnemy(Collider other)
    {
        enemy =other.GetComponent<Rigidbody>();
    }

    private void Attack()
    {
        //знаю, что лучше сделать пул, но в данном примере у нас спавнятся ровно 2 обьекта
        Rocket rocket = Instantiate(rocketPrefab, rocketSpawnrPosition.position, Quaternion.identity );
        rocket.Initialize(enemy);
    }
}
