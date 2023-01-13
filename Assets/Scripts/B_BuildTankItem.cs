using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_BuildTankItem : MonoBehaviour
{
    public FrameModel Frame;
    public TurretModel Turret;
    public WeaponModel Weapon;
    public WheelModel Wheel;
    public ImprovementModel Improvement;

    public TankBuilder TankBuilder;


    private void Start()
    {
        TankBuilder = GameObject.Find("TankBuilder").GetComponent<TankBuilder>();
    }


    public void SetSelectedItem()
    {
        if (Frame != null)
        {
            TankBuilder.SetFrame(Frame);
        }
        else if(Turret != null)
        {
            TankBuilder.SetTurret(Turret);

        }
        else if (Weapon != null)
        {
            TankBuilder.SetWeapon(Weapon);
        }
        else if (Wheel != null)
        {
            TankBuilder.SetWheel(Wheel);
        }
        else if (Improvement != null)
        {
            TankBuilder.SetImprovement(Improvement);
        }
    }
}
