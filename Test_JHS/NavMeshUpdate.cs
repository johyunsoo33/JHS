using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class NavMeshUpdate : MonoBehaviour
{
    public NavMeshSurface navMeshSurface;
    void Start()
    {
        InvokeRepeating("RebuildNavMesh", 0f, 1f); // 0�� �� �����ؼ� �� 1�ʸ��� ����
    }
    void RebuildNavMesh()
    {
        navMeshSurface.BuildNavMesh();
    }
}
