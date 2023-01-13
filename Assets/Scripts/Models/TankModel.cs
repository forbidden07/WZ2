using UnityEngine.UI;

public class TankModel
{
    public string Name
    {
        get { return GetName(); }
    }

    public int HP
    {
        get { return GetHP(); }
    }


    public int Damage;
    public float Speed;
    public float Accuracy;
    public float FireSpeed;
    public float Defense;
    public int Weight;
    public int Cost;

    public FrameModel Frame;
    public TurretModel Turret;
    public WheelModel Wheel;

    public Image BlueprintImage;

    private string GetName()
    {
        var name = string.Empty;

        if (Frame != null)
        {
            name = Frame.Name;
        }

        if (Turret.Weapon != null)
        {
            name += Turret.Weapon.Name;
        }

        if (Wheel != null)
        {
            name += Wheel.Name;
        }

        return name;
    }
    private int GetHP()
    {
        var hp = 0;

        if (Frame != null)
        {
            hp = Frame.HP;
        }

        if (Turret.Weapon != null)
        {
            hp += Turret.Weapon.HP;
        }

        if (Wheel != null)
        {
            hp += Wheel.HP;
        }

        return hp;
    }
}
