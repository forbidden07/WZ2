using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FrameContainer 
{
    public static List<FrameModel> GetAll()
    {
        return new List<FrameModel>()
        {
            new FrameModel()
            {
                Name = "Vipère",
            },
            new FrameModel()
            {
                Name = "Cobra",
            },
            new FrameModel()
            {
                Name = "Python",
            }
        };
    }
}
