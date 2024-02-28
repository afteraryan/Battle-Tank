using UnityEngine;

public class TankController
{
    private TankView _tankView;
    private TankModel _tankModel;

    private Rigidbody rb;

    public TankController(TankView tankView, TankModel tankModel)
    {
        _tankModel = tankModel;
        _tankView = GameObject.Instantiate<TankView>(tankView);

        _tankView.SetController(this);
        _tankModel.SetController(this);
        
        rb = _tankView.GetRigidBody();
    }

    public void Move(float movement, float speed)
    {
        rb.velocity = _tankView.transform.forward * movement * speed;
    }
    
    public void Rotate(float rotation, float speed)
    {
        float turn = rotation * speed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }

    public TankModel GetTankModel()
    {
        return _tankModel;
    }
}