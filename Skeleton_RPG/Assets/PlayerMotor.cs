using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour
{
    //Reffrence to NavMesh agent
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        //Getting the Navmesh agent component
        agent = GetComponent<NavMeshAgent>();
        
    }

public void MoveToPoint( Vector3 point )
{
    agent.SetDestination(point) ;

}

}
