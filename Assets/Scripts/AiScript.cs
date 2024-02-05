using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiScript : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 point;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position,point) <1)
        {
            IterateWaypointIndex();
            UpdateDestination();
            Debug.Log("finding");

        }

    }
    void UpdateDestination()
    {
        point = waypoints[waypointIndex].position;
        agent.SetDestination(point);
        

    }

    void IterateWaypointIndex()
    {

        waypointIndex++;
        Debug.Log("next destination" + point);
        if (waypointIndex == waypoints.Length)
        {

            waypointIndex = 0;
            UpdateDestination();
        }




    }
}
