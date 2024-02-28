using UnityEngine;

public class TankModel
{
    private TankController _tankController;
    
    public float _movementSpeed;
    public float _rotationSpeed;

    public TankModel(float movementSpeed, float rotationSpeed)
    {
        _movementSpeed = movementSpeed;
        _rotationSpeed = rotationSpeed;
    }
    
    public void SetController(TankController tankController)
    {
        _tankController = tankController;
    }
}
