using UnityEngine;

public class Turret : MonoBehaviour
{

    #region Tooltip
    [Tooltip("populate with first part of Turret's head")]
    #endregion
    [SerializeField] GameObject partOfTurret;
    #region Tooltip
    [Tooltip("populate with sparklEffect from prefab")]
    #endregion
    [SerializeField] GameObject particleEffect;

    private Rigidbody _rb;
    private IDamageble _enemy;

    public Rigidbody Rb { get => _rb; }
    public IDamageble Enemy { get => _enemy; set => _enemy = value; }
    public GameObject PartOfTurret { get => partOfTurret;  }
    public GameObject ParticleEffect { get => particleEffect;  }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
}
