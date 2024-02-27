using UnityEngine;

public class TankController
{
    private TankView _tankView;
    private TankModel _tankModel;
    
    public TankController(TankView tankView, TankModel tankModel)
    {
        _tankView = tankView;
        _tankModel = tankModel;
        
        _tankView.SetController(this);
        _tankModel.SetController(this);
        
        InstantiateTank();
    }

    private void InstantiateTank()
    {
        GameObject.Instantiate(_tankView.gameObject);
    }
}
