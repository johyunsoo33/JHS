using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class peddlerNav : MonoBehaviour
{

    public Transform player;
    NavMeshAgent nvAgent;
    public float followRange = 3.0f; // 추적 범위

    void Start()
    {
        nvAgent = GetComponent<NavMeshAgent>();
    }
    void Update()
    { // 플레이어와의 거리 계산
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        // 거리가 추적 범위 이내일 경우 플레이어를 따라감
        if (distanceToPlayer <= followRange)
        {
            nvAgent.SetDestination(player.position);
        }
    }
}
