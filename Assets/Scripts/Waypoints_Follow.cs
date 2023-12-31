using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints_Follow : MonoBehaviour
{
    public GameObject[] waypoints;
    int currentWaypointIndex = 0;
    public float speed = 2f;
    void Update()
    {
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
