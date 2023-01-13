using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TankBuilder : MonoBehaviour
{
    private GameObject P_TankItemList;
    public List<TankModel> Tank_BluePrint_List = new List<TankModel>();
    public List<GameObject> Blueprints = new List<GameObject>();
    public GameObject P_ItemList;
    public List<GameObject> Items = new List<GameObject>();
    public ImageContainer ImageContainer;

    public TurretPrefabContainer TurretPrefabContainer;
    public WheelPrefabContainer WheelPrefabContainer;
    public FramePrefabContainer FramePrefabContainer;
    public ImprovementprefabContainer ImprovementPrefabContainer;
    public WeaponPrefabContainer WeaponPrefabContainer;

    public GameObject Displayer;
    public GameObject FramePoint; 

    #region newTank

    public TankModel NewTankModel;

    private GameObject Frame;
    private GameObject Turret;
    private GameObject LWheel;
    private GameObject RWheel;
    private GameObject LImprovement;
    private GameObject RImprovement;
    private GameObject Weapon;

    #endregion

    #region  RessourceItem

    public List<FrameModel> AllFrame;
    public List<WheelModel> AllWheel;
    public List<WeaponModel> AllWeapon;
    public List<ImprovementModel> AllImprovement;
    public List<TurretModel> AllTurret;

    #endregion

    #region  Buttons

    public GameObject B_Frame;
    public GameObject B_Turret;
    public GameObject B_Wheel;
    public GameObject B_Improvement;
    public GameObject B_Weapon;

    #endregion

    #region  Prefabs

    public GameObject P_Blueprint;
    public GameObject P_Item;

    #endregion

    void Start()
    {
        P_TankItemList = GameObject.Find("P_TankItemList");
        Tank_BluePrint_List.Add(TankContainer.GetEmptyTank());
        Tank_BluePrint_List.Add(TankContainer.GetBasicTank());
        ShowBlueprintList();

        AllFrame = FrameContainer.GetAll();
        AllWheel = WheelContainer.GetAll();
        AllWeapon = WeaponContainer.GetAll();
        AllTurret = TurretContainer.GetAll();
        AllImprovement = ImprovementContainer.GetAll();

        NewTankModel = TankContainer.GetEmptyTank();
        ShowItems(0);
    }

    void Update()
    {
        Displayer.transform.Rotate(new Vector3(0, 0, 0.1f));

        if (NewTankModel.Frame == null)
        {
            B_Turret.GetComponent<Button>().interactable = false;
            B_Wheel.GetComponent<Button>().interactable = false;
            B_Improvement.GetComponent<Button>().interactable = false;
            B_Weapon.GetComponent<Button>().interactable = false;
        }
        else
        {
            B_Turret.GetComponent<Button>().interactable = true;
            B_Wheel.GetComponent<Button>().interactable = true;
        }

        if (NewTankModel.Turret == null)
        {
            B_Improvement.GetComponent<Button>().interactable = false;
            B_Weapon.GetComponent<Button>().interactable = false;
        }
        else
        {
            if (Turret.GetComponent<Turret>().Improvement1Point != null)
            {
                B_Improvement.GetComponent<Button>().interactable = true;
            }
            else
            {
                B_Improvement.GetComponent<Button>().interactable = false;
            }

            B_Weapon.GetComponent<Button>().interactable = true;
        }
    }

    public void ShowItems(int itemType)
    {
        if (Items.Any())
        {
            foreach (var item in Items)
            {
                GameObject.Destroy(item);
            }

            Items.Clear();
        }

        switch ((ItemType)itemType)
        {
            case ItemType.Frame:
                foreach (var frame in AllFrame)
                {
                    var item = Instantiate(P_Item, P_ItemList.transform);
                    item.GetComponent<Image>().sprite = ImageContainer.Sprites.SingleOrDefault(e => e.name == frame.Name);
                    item.GetComponent<B_BuildTankItem>().Frame = frame;
                    Items.Add(item);
                }
                break;
            case ItemType.Turret:
                foreach (var turret in AllTurret)
                {
                    var item = Instantiate(P_Item, P_ItemList.transform);
                    item.GetComponent<Image>().sprite = ImageContainer.Sprites.SingleOrDefault(e => e.name == turret.Name);
                    item.GetComponent<B_BuildTankItem>().Turret = turret;
                    Items.Add(item);
                }
                break;
            case ItemType.Wheel:
                foreach (var wheel in AllWheel)
                {
                    var item = Instantiate(P_Item, P_ItemList.transform);
                    item.GetComponent<Image>().sprite = ImageContainer.Sprites.SingleOrDefault(e => e.name == wheel.Name);
                    item.GetComponent<B_BuildTankItem>().Wheel = wheel;
                    Items.Add(item);
                }
                break;
            case ItemType.Improvement:
                foreach (var improvement in AllImprovement)
                {
                    var item = Instantiate(P_Item, P_ItemList.transform);
                    item.GetComponent<Image>().sprite = ImageContainer.Sprites.SingleOrDefault(e => e.name == improvement.Name);
                    item.GetComponent<B_BuildTankItem>().Improvement = improvement;
                    Items.Add(item);
                }
                break;
            case ItemType.Weapon:
                foreach (var weapon in AllWeapon)
                {
                    var item = Instantiate(P_Item, P_ItemList.transform);
                    item.GetComponent<Image>().sprite = ImageContainer.Sprites.SingleOrDefault(e => e.name == weapon.Name);
                    item.GetComponent<B_BuildTankItem>().Weapon = weapon;
                    Items.Add(item);
                }
                break;
        };
    }

    void ShowBlueprintList()
    {
        if (Blueprints.Any())
        {
            foreach (var blueprint in Blueprints)
            {
                GameObject.Destroy(blueprint);
            }

            Blueprints.Clear();
        }

        foreach (var blueprint in Tank_BluePrint_List)
        {
            Blueprints.Add(Instantiate(P_Blueprint, P_TankItemList.transform));
        }
    }

    public void SetFrame(FrameModel frame)
    {
        if (NewTankModel.Frame != null)
        {
            Destroy(Frame);
            Destroy(Turret);
            Destroy(LWheel);
            Destroy(RWheel);
            NewTankModel.Frame = null;
            NewTankModel.Wheel = null;
            NewTankModel.Turret = null;
        }

        NewTankModel.Frame = frame;
        Frame = Instantiate(FramePrefabContainer.FramesPrefab.SingleOrDefault(e => e.name == frame.Name), FramePoint.transform);
    }

    public void SetWheel(WheelModel wheel)
    {
        if (NewTankModel.Wheel != null)
        {
            Destroy(LWheel);
            Destroy(RWheel);
            NewTankModel.Wheel = null;
            LWheel = null;
            RWheel = null;
        }

        NewTankModel.Wheel = wheel;
        LWheel = Instantiate(WheelPrefabContainer.WheelsPrefab.SingleOrDefault(e => e.name == "L " + wheel.Name), Frame.GetComponent<Frame>().LWheelPoint.transform);
        RWheel = Instantiate(WheelPrefabContainer.WheelsPrefab.SingleOrDefault(e => e.name == "R " + wheel.Name), Frame.GetComponent<Frame>().RWheelPoint.transform);

    }

    public void SetTurret(TurretModel turret)
    {
        if (NewTankModel.Turret != null)
        {
            Destroy(Turret);
            NewTankModel.Turret = null;
            Turret = null;
        }

        NewTankModel.Turret = turret;
        Turret = Instantiate(TurretPrefabContainer.TurretsPrefab.SingleOrDefault(e => e.name == turret.Name), Frame.GetComponent<Frame>().TurretPoint.transform);
        Turret.transform.localPosition = new Vector3(0, 0, 0);
    }

    public void SetWeapon(WeaponModel weapon)
    {
        if (NewTankModel.Turret.Weapon != null)
        {
            Destroy(Weapon);
            NewTankModel.Turret.Weapon = null;
            Weapon = null;
        }

        NewTankModel.Turret.Weapon = weapon;
        Weapon = Instantiate(WeaponPrefabContainer.WeaponsPrefab.SingleOrDefault(e => e.name == weapon.Name), Turret.GetComponent<Turret>().WeaponPoint.transform);
        Weapon.transform.localPosition = new Vector3(0, 0, 0);

    }
    public void SetImprovement(ImprovementModel improvement)
    {
        if (NewTankModel.Turret.Improvement1 != null)
        {
            Destroy(LImprovement);
            NewTankModel.Turret.Improvement1 = null;
            LImprovement = null;
        }

        NewTankModel.Turret.Improvement1 = improvement;
        LImprovement = Instantiate(ImprovementPrefabContainer.ImprovementPrefab.SingleOrDefault(e => e.name == improvement.Name), Turret.GetComponent<Turret>().Improvement1Point.transform);
    }
}
