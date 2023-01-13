using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public GameObject P_BuildTank;
    public GameObject RoomCamera;
    public GameObject MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        P_BuildTank = GameObject.Find("P_BuildTank");
    }

    public void OpenCloseBuildTankMenu()
    {
        if (P_BuildTank.activeInHierarchy)
        {
            P_BuildTank.SetActive(false);
            RoomCamera.SetActive(false);
            MainCamera.SetActive(true);
        }
        else
        {
            P_BuildTank.SetActive(true);
            RoomCamera.SetActive(true);
            MainCamera.SetActive(false);
        }
    }
}
