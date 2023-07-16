using UnityEngine;

public class Rocket : MonoBehaviour
{
    #region ToolTip
    [Tooltip("populate with rocket Model")]
    #endregion
    [SerializeField] GameObject rocketModel;
    #region ToolTip

    [Tooltip("populate with effect from prefab")]
    #endregion
    [SerializeField] GameObject explosionEffectPrefab;
    #region ToolTip

    [Tooltip("populate with fire stream effect  from prefab")]
    #endregion
    [SerializeField] GameObject fireStreamEffectPrefab;


    private Rigidbody _rocketRB;
    private Rigidbody _enemyBody;
    private IDamageble _enemyHealth;
    private RocketHit _rocketExplosion;
    private RocketMovement _rocketMovement;

    public Rigidbody RocketRB { get => _rocketRB;  }
    public Rigidbody EnemyBody { get => _enemyBody; }
    public IDamageble EnemyHealth { get => _enemyHealth; }
    public GameObject RocketModel { get => rocketModel; }
    public GameObject ExplosionEffectPrefab { get => explosionEffectPrefab;  }
    public GameObject FireStreamEffectPrefab { get => fireStreamEffectPrefab;}

    public void Initialize(Rigidbody enemy)
    {
        _enemyBody = enemy;
        _enemyHealth = (IDamageble)enemy.GetComponent(typeof(IDamageble));
        _rocketRB = GetComponent<Rigidbody>();
        _rocketExplosion = GetComponent<RocketHit>();
        _rocketExplosion.Ñonstruct(this);
        _rocketMovement = GetComponent<RocketMovement>();
        _rocketMovement.Ñonstruct(this);

    }

   

   
}
