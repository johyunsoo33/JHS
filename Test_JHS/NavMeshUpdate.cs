using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class NavMeshUpdate : MonoBehaviour
{
    public NavMeshSurface navMeshSurface;
    void Start()
    {
        InvokeRepeating("RebuildNavMesh", 0f, 1f); // 0초 후 시작해서 매 1초마다 실행
    }
    void RebuildNavMesh()
    {
        navMeshSurface.BuildNavMesh();
    }
}
