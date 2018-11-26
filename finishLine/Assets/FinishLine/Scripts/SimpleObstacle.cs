using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleObstacle : MonoBehaviour
{
    public float maxDecrease = 10f;

    private void OnTriggerEnter(Collider other)
    {
        var collidedAgent = other.gameObject.GetComponentInParent<NavMeshAgent>();
        if(collidedAgent)
        {
            var decreaseAmount = Random.Range(maxDecrease, collidedAgent.speed - 1);
            collidedAgent.SendMessage("onGetHit", decreaseAmount, SendMessageOptions.DontRequireReceiver);
        }
    }


}
