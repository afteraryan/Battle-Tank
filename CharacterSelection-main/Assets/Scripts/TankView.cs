using System;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController _tankController;
    [SerializeField] private Rigidbody rb;

    private float _movement;
    private float _rotation;

    private void Update()
    {
        Move();
    }

    private void CalculateMovement()
    {
        _movement = Input.GetAxis("Vertical");
        _rotation = Input.GetAxis("Horizontal");
    }

    private void Move()
    {
        CalculateMovement();
        
        if (_movement != 0)
            _tankController.Move(_movement, 25);
        
        if(_rotation != 0)
            _tankController.Rotate(_rotation, 80);
    }

    public void SetController(TankController tankController)
    {
        _tankController = tankController;
    }

    public Rigidbody GetRigidBody()
    {
        return rb;
    }
}
