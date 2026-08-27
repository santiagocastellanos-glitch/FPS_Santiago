using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float health = 10;

    [SerializeField]
    private GameObject knife;

    private NavMeshAgent agent;

    private Transform player;

    [SerializeField]
    public List<Transform> patrolPoint = new List<Transform>();

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").transform;
        agent.stoppingDistance = 1;
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
            agent.destination = patrolPoint[0].position;
        }

        if (Vector3.Distance(transform.position, player.position) <= agent.stoppingDistance)
        {
            knife.SetActive(true);
        }
        else
        {
            knife.SetActive(true);
        }
    }
    public void TakeDamage(float value)
    {
        health -= value;
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
