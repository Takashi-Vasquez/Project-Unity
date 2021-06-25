using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Guardian : MonoBehaviour
{
    public GameObject player;

    private NavMeshAgent navmesh;

    // Start is called before the first frame update
    void Start()
    {
        navmesh = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
       navmesh.destination = player.transform.position; 
    }
}
