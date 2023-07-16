using UnityEngine;

public class TurretHealth :MonoBehaviour, IDamageble
{
    private Turret _turret;
    private void Start()
    {
        _turret = GetComponent<Turret>();
    }
    public void GetDamage(Vector3 explosionPosition)
    {
        _turret.PartOfTurret.SetActive(false);
        _turret.ParticleEffect.SetActive(true);
    }
}
