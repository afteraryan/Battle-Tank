using System;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private TankView tankView;

    private void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(15, 80);
        TankController tankController = new TankController(tankView, tankModel);
    }
}
