using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WeaponContainer 
{
    public static List<WeaponModel> GetAll()
    {
        return new List<WeaponModel>()
        {
            new WeaponModel()
            {
                Name = "Small PM",
            },
            new WeaponModel()
            {
                Name = "Medium PM",
            },
            new WeaponModel()
            {
                Name = "Heavy PM",
            },
            new WeaponModel()
            {
                Name = "Double heavy PM",
            },
            new WeaponModel()
            {
                Name = "Small cannon",
            },
            new WeaponModel()
            {
                Name = "Medium cannon",
            },
            new WeaponModel()
            {
                Name = "Heavy cannon",
            },
            new WeaponModel()
            {
                Name = "Small laser",
            },
            new WeaponModel()
            {
                Name = "Medium laser",
            },
            new WeaponModel()
            {
                Name = "Heavy laser",
            }
        };
    }
}
