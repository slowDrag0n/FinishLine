using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavDestination : MonoBehaviour
{

    public Transform destinationTransform;

    private void Start()
    {
        this.gameObject.GetComponent<NavMeshAgent>().destination = this.destinationTransform.position;
    }
}
