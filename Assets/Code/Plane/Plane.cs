using UnityEngine;

public class Plane : MonoBehaviour
{

    private bool _isDead;
    private Rigidbody _rb;
   
    public bool IsDead { get => _isDead; set => _isDead = value; }
    public Rigidbody Rb { get => _rb;  }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

  

    
}
