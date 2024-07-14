using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCode : MonoBehaviour
{
    public NavMeshAgent agent;

    private GameObject player;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        agent.SetDestination(player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
        animator.SetFloat("Speed", agent.velocity.magnitude);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("bullets"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
