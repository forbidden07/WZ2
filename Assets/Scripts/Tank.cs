using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tank : MonoBehaviour
{
    public GameObject Frame;
    public GameObject LeftWheel;
    public GameObject RightWheel;
    public GameObject Turret1;
    public GameObject Turret2;
    public GameObject Weapon1;
    public GameObject Weapon2;
    public GameObject Improvement1Weapon1;
    public GameObject Improvement2Weapon1;
    public GameObject Improvement1Weapon2;
    public GameObject Improvement2Weapon2;

    public GameObject Target;
    public GameObject Destination;
    public NavMeshAgent Agent;

    public TankModel features;

    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        TargetTarget();
    }

    public void TargetTarget()
    {
        if (Target)
        {
            ViewTheTarget();
            SetDestination();
        }
    }

    private void ViewTheTarget()
    {
        if (Turret1)
        {
            Vector3 direction = Target.transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            Turret1.transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 10f * Time. fixedDeltaTime);
        }

        if (Turret2)
        {
            Vector3 direction2 = Target.transform.position - transform.position;
            Quaternion rotation2 = Quaternion.LookRotation(direction2);
            Turret1.transform.rotation = Quaternion.Slerp(transform.rotation, rotation2, 10f * Time.fixedDeltaTime);
        }
    }

    private void SetDestination()
    {

        Agent.SetDestination(Target.transform.position);
    }

}
