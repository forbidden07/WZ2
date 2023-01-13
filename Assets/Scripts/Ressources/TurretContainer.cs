using System.Collections.Generic;

public static class TurretContainer
{
    public static List<TurretModel> GetAll()
    {
        return new List<TurretModel>()
        {
            new TurretModel()
            {
                Name = "Small turret",
            },
            new TurretModel()
            {
                Name = "Medium turret",
            },
            new TurretModel()
            {
                Name = "Heavy turret",
            },
            new TurretModel()
            {
                Name = "Small turret, 1 improvement",
            },
            new TurretModel()
            {
                Name = "Medium turret, 1 improvement",
            },
            new TurretModel()
            {
                Name = "Heavy turret, 1 improvement",
            },
            new TurretModel()
            {
                Name = "Small turret, 2 improvement",
            },
            new TurretModel()
            {
                Name = "Medium turret, 2 improvement",
            },
            new TurretModel()
            {
                Name = "Heavy turret, 2 improvement",
            }
        };
    }
}
