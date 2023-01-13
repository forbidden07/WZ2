using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TankContainer
{
    public static TankModel GetEmptyTank()
    {
        return new TankModel();
    }

    public static TankModel GetBasicTank()
    {
        return new TankModel()
        {
            Turret = new TurretModel()
            {
                Cost = 1,
                Defense = 1,
                HP = 50,
                Improvement1 = null,
                Improvement2 = null,
                Name = "Basic Turret",
                Weight = 35,
                Weapon = new WeaponModel()
                {
                    Cost = 1,
                    Damage = 1,
                    Defense = 1,
                    HP = 10,
                    FireSpeed = 1f,
                    Name = "Basic PM",
                    Weight = 10,
                }
            },
            Wheel = new WheelModel()
            {
                Cost = 1,
                Defense = 1,
                HP = 30,
                Name = "Basic Wheels",
                Power = 50,
                Weight = 85,
            },
            Frame = new FrameModel()
            {
                Cost = 1,
                Defense = 1,
                HP = 350,
                Name = "Basic Frame",
                Weight = 150,
            },
        };
    }
}
