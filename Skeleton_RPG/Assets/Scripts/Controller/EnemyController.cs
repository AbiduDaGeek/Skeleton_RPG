﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadious = 10f;
    Transform target;
    NavMeshAgent agent;
    CharacterCombat combat;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerManager.instance.player is a Game Object
        //Convert it to transform by .transform
        target = PlayerManager.instance.player.transform; 
        agent = GetComponent<NavMeshAgent>();
        combat = GetComponent<CharacterCombat>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookRadious)
        {
            agent.SetDestination(target.position);
            if (distance <= agent.stoppingDistance)
            {
                CharacterStats targetStats = target.GetComponent<CharacterStats>();
                if (targetStats != null)
                {
                    //Attack
                    combat.Attack(targetStats);
                }
                
                // face the target
                FaceTarget();
            }
        }        
        
    }
    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadious);
    }
}
