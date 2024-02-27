using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController _tankController;
    
    public void SetController(TankController tankController)
    {
        _tankController = tankController;
    }
}
