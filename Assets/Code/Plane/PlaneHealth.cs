using UnityEngine;

public class PlaneHealth : MonoBehaviour, IDamageble
{
    #region
    [Space(5)]
    [Header("explosionDetails")]
    #endregion
    [SerializeField] private float explosionForce;
    [SerializeField] private float exposionRadius;

    private Plane _plane;
    private Rigidbody[] _planeParts;
    
    private void Start()
    {
        _plane = GetComponent<Plane>();
        _planeParts = GetComponentsInChildren<Rigidbody>();
    }

    public void GetDamage(Vector3 explosionPosition)
    {
        _plane.IsDead = true;
        
        foreach (Rigidbody item in _planeParts)
        {
            item.isKinematic = false;
            item.useGravity = true;
            item.AddExplosionForce(explosionForce, explosionPosition, exposionRadius, 10, ForceMode.Impulse);
        }
    }

}
