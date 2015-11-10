﻿using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public float deathDistance = 0.5f;
    public float distanceAway;
    public Transform thisObject;
    public Transform target;
    private NavMeshAgent navComponent;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navComponent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {

        float dist = Vector3.Distance(target.position, transform.position);

        if (target)
        {
            navComponent.SetDestination(target.position);
        }

        else
        {
            if (target = null)
            {
                target = this.gameObject.GetComponent<Transform>();
            }
            else
            {
                target = GameObject.FindGameObjectWithTag("Player").transform;
            }
        }
        if (dist <= deathDistance)
        {
            //KILL PLAYER
        }
    }
}