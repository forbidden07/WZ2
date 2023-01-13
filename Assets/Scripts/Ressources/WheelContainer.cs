using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WheelContainer 
{
    public static List<WheelModel> GetAll()
    {
        return new List<WheelModel>()
        {
            new WheelModel()
            {
                Name = "Small wheel",
            },
            new WheelModel()
            {
                Name = "Medium wheel",
            },
            new WheelModel()
            {
                Name = "Heavy wheel",
            },
            new WheelModel()
            {
                Name = "Spider wheel",
            },
            new WheelModel()
            {
                Name = "Over",
            },
            new WheelModel()
            {
                Name = "Wing",
            }
        };
    }
}
