using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMover : MonoBehaviour {
    public Transform[] points;
    public float pointDist = 3f;
    NavMeshAgent agent;
    bool isActiv = false;
    int currentInd = 0;
    Transform currentPoint;

	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        if (points.Length > 0)
        {
            isActiv = true;
            currentPoint = points[currentInd];
            agent.SetDestination(currentPoint.position);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isActiv)
        {
            float dist = Vector3.Distance(transform.position, currentPoint.position);
            if (dist <= pointDist)
            {
                currentInd = (currentInd + 1) % points.Length;
                currentPoint = points[currentInd];
            }
            agent.SetDestination(currentPoint.position);
        }
	}
}
