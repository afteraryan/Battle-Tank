using System;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController _tankController;
    [SerializeField] private Rigidbody rb;

    private float _movement;
    private float _rotation;

    private void Start()
    {
        SetCamera();
    }

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
            _tankController.Move(_movement, _tankController.GetTankModel()._movementSpeed);
        
        if(_rotation != 0)
            _tankController.Rotate(_rotation, _tankController.GetTankModel()._rotationSpeed);
    }

    public void SetController(TankController tankController)
    {
        _tankController = tankController;
    }

    public Rigidbody GetRigidBody()
    {
        return rb;
    }

    private void SetCamera()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0, 3, -4);
    }
}
