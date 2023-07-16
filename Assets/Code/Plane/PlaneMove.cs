using UnityEngine;

public class PlaneMove : MonoBehaviour
{
    [SerializeField] private float speed;
  
    private Plane _plane;
    private Rigidbody _rb;
   
    private void Start()
    {
        _plane = GetComponent<Plane>();
        _rb = _plane.Rb;
    }

    private void FixedUpdate()
    {
        if (_plane.IsDead) return;

        Move();
    }

    private void Move()
    {
        _rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Force);
    }
}
