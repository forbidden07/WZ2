using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class ImprovementContainer 
{
    public static Image Radar;

    public static List<ImprovementModel> GetAll()
    {
        return new List<ImprovementModel>()
        {
            new ImprovementModel()
            {
                Name = "Radar",
            },
            new ImprovementModel()
            {
                Name = "Laser",
            },
            new ImprovementModel()
            {
                Name = "Quick reload",
            },
            new ImprovementModel()
            {
                Name = "Explosive Bullets",
            },
            new ImprovementModel()
            {
                Name = "Armor piercing bullets",
            },
            new ImprovementModel()
            {
                Name = "Fire speed",
            },
            new ImprovementModel()
            {
                Name = "Energy shield",
            },
            new ImprovementModel()
            {
                Name = "Auto repair",
            }
        };
    }
}
