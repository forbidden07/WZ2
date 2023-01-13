using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject MainCamera;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (MainCamera.activeInHierarchy)
        {
            if (Input.GetMouseButtonDown(0))
            {
                var worldPosition = new Vector3();
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitData;
                if (Physics.Raycast(ray, out hitData, 1000))
                {
                    worldPosition = hitData.point;
                }

                GameObject.Find("Target").transform.position = worldPosition;
            }
        }
    }
}
