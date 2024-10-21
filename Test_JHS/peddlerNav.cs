using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class peddlerNav : MonoBehaviour
{

    public Transform player;
    NavMeshAgent nvAgent;
    public float followRange = 3.0f; // ���� ����

    void Start()
    {
        nvAgent = GetComponent<NavMeshAgent>();
    }
    void Update()
    { // �÷��̾���� �Ÿ� ���
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        // �Ÿ��� ���� ���� �̳��� ��� �÷��̾ ����
        if (distanceToPlayer <= followRange)
        {
            nvAgent.SetDestination(player.position);
        }
    }
}
