using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DamageTaker : MonoBehaviour
{
    public float recoveryWithinTime = 2f;

    private NavMeshAgent agent;
    private float originalSpeed;

    private void Awake()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
        originalSpeed = agent.speed;
    }

    public void onGetHit(float decreaseSpeedAmount)
    {
        StartCoroutine(decreaseSpeedCo(agent.speed - decreaseSpeedAmount, recoveryWithinTime));
    }

    IEnumerator decreaseSpeedCo(float reducedSpeed, float dur)
    {
        float elapsedTime = 0f;

        while(elapsedTime < dur)
        {
            agent.speed = Mathf.Lerp(reducedSpeed, originalSpeed, (elapsedTime / dur));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
