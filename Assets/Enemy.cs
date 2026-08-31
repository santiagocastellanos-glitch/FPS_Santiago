using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;
using DG.Tweening;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float health = 10;

    [SerializeField]
    private GameObject knife;

    private NavMeshAgent agent;

    private Transform player;

    [SerializeField]
    public List<Transform> patrolPoint = new List<Transform>(3);

    int currentPoint = 0;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").transform;
        agent.stoppingDistance = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.position) <= 10)
        {
            agent.destination = player.position;
        }
        else
        {
            if(Vector3.Distance(transform.position, patrolPoint[currentPoint].position) >= 3)
            {
                agent.destination = patrolPoint[currentPoint].position;
            }
            else
            {
                if (currentPoint < patrolPoint.Count)
                {
                    currentPoint++;
                }
                else
                {
                    currentPoint = 0;
                }
            }
        }

        if (Vector3.Distance(transform.position, player.position) <= agent.stoppingDistance)
        {
            knife.SetActive(true);
        }
        else
        {
            knife.SetActive(false);
        }
    }
    public void TakeDamage(float value)
    {
        health -= value;
        GetComponent<MeshRenderer>().material.DOColor(Color.red, 1).From();
        GetComponent<MeshRenderer>().material.DOColor(Color.gray, 1);
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
