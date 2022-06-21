using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 2f;

    private Transform target;
    private int wavepointIndex = 0;
    Vector2 Start1 = new Vector2(-8.2538f, -0.4851f);
    Vector2 Start2 = new Vector2(8.21f, -1.96f);
    Vector2 Start3 = new Vector2(-4.7f, 4.22f);
    Vector2 flag;



    void Start()
    {
        flag = transform.position;
        if (Vector2.Distance(transform.position, Start1) <= 0.2f)
        {
            target = Waypoints1.points[0];
        }
        if (Vector2.Distance(transform.position, Start2) <= 0.2f)
        {
            target = Waypoints2.points[0];
        }
        if (Vector2.Distance(transform.position, Start3) <= 0.2f)
        {
            target = Waypoints3.points[0];
        }

        //target = Waypoints2.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            if (Vector2.Distance(flag, Start1) <= 0.2f)
            {
                GetNextWaypoint1();
            }
            if (Vector2.Distance(flag, Start2) <= 0.2f)
            {
                GetNextWaypoint2();
            }
            if (Vector2.Distance(flag, Start3) <= 0.2f)
            {
                GetNextWaypoint3();
            }
        }
    }

    void GetNextWaypoint1()
    {
        if (wavepointIndex >= Waypoints1.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        wavepointIndex++;
        target = Waypoints1.points[wavepointIndex];
    }

    void GetNextWaypoint2()
    {
        if (wavepointIndex >= Waypoints2.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        wavepointIndex++;
        target = Waypoints2.points[wavepointIndex];
    }

    void GetNextWaypoint3()
    {
        if (wavepointIndex >= Waypoints3.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        wavepointIndex++;
        target = Waypoints3.points[wavepointIndex];
    }
}
