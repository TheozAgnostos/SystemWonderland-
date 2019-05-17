using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RPG_Mover : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent nav;

    void Start()  
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
       nav.destination = target.position;
    }
}
