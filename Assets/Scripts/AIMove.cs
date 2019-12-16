﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    private AISpawner m_AIManager;

    private bool m_hasTarget;
    private bool m_isTurning;

    private Vector3 m_wayPoint;
    private Vector3 m_lastWaypoint;

    //private Animator m_animator;
    private float m_speed;

    private Collider m_collider;

    // Start is called before the first frame update
    void Start()
    {
        m_AIManager = transform.parent.GetComponentInParent<AISpawner>();
        //m_animator = GetComponent<Animator>();

        SetUpNPC();
    }

    void SetUpNPC()
    {
        float m_scale = Random.Range(.7f, 1.2f);
        transform.localScale += new Vector3(m_scale * 0.015f, m_scale * 0.01f, m_scale * 0.01f);
        
        if (transform.GetComponent<Collider>() != null && transform.GetComponent<Collider>().enabled == true)
        {
            m_collider = transform.GetComponent<Collider>();
        }
        else if (transform.GetComponentInChildren<Collider>() != null && transform.GetComponentInChildren<Collider>().enabled == true)
        {
            m_collider = transform.GetComponentInChildren<Collider>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_hasTarget)
        {
            m_hasTarget = CanFindTarget();
        }
        else
        {
            RotateNPC(m_wayPoint, m_speed);
            transform.position = Vector3.MoveTowards(transform.position, m_wayPoint, m_speed * Time.deltaTime);

            CollidedNPC();
        }

         if(transform.position == m_wayPoint)
        {
            m_hasTarget = false;
        }
    }

    void CollidedNPC()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, transform.localScale.z))
        {
            if (hit.collider == m_collider | hit.collider.tag == "Waypoint")
            {
                return;
            }

            int randomNum = Random.Range(1, 100);
            if (randomNum < 20)
                m_hasTarget = false;
        }
    }

    Vector3 GetWaypoint (bool isRandom)
    {
        if (isRandom)
        {
            return m_AIManager.RandomPosition();
        }
        else
        {
            return m_AIManager.RandomWaypoint();
        }
    }

    bool CanFindTarget(float start = .1f, float end = .2f)
    {
        if (m_lastWaypoint == m_wayPoint)
        {
            //m_wayPoint = GetWaypoint(true);
            m_wayPoint = m_AIManager.RandomWaypoint();
            return false;
        }
        else
        {
            m_lastWaypoint = m_wayPoint;
            m_speed = Random.Range(start, end);
            //m_animator.speed = m_speed;
            return true;
        }
    }

    void RotateNPC (Vector3 waypoint, float currentSpeed)
    {
        float TurnSpeed = currentSpeed * Random.Range(1f, 3f);
        Vector3 LookAt = waypoint - this.transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(LookAt), TurnSpeed * Time.deltaTime);
    }
}
