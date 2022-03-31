using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombie : MonoBehaviour
{ 
    NavMeshAgent agent;
    public GameObject joueur;
    int pv;

// Start is called before the first frame update
void Start()
{
    agent = GetComponent<NavMeshAgent>();
    pv = 3;
}

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(joueur.transform.position);

    }
}
