using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {
    private NavMeshAgent agent;
    private Transform player;
    public float minDistance = 2f;
    public float attackDelay = 1f;
    private float attakTime = 0f;
    public float damage = 7f;
    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        agent.stoppingDistance = minDistance;
        agent.SetDestination(player.position);
	}
	
	// Update is called once per frame
	void Update () {
		if(attakTime > 0)
        {
            attakTime -= Time.deltaTime;
        }

        float distance = Vector3.Distance(transform.position, player.position);


        if(distance <= minDistance + 1 && attakTime <= 0f)
        {
            Attack();
        }
        agent.SetDestination(player.position);
    }

    void Attack()
    {
        attakTime = attackDelay;
        player.GetComponent<PlayerManager>().ReciveDamage(damage);
    }
}
