using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ennemis : MonoBehaviour
{
    private NavMeshAgent navAgent;
    public GameObject cible; // Le joueur principal

    // Start is called before the first frame update
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 destination = cible.transform.position;
        navAgent.SetDestination(destination);
    }

    void Touche()
    {

    }
}
