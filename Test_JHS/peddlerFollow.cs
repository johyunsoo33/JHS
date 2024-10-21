using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class peddlerFollow : MonoBehaviour
{
    public NavMeshSurface navMeshSurface;  // 네브메쉬가 적용된 NavMeshSurface 컴포넌트

    // 이 함수는 다른 스크립트에서 호출될 수 있음
    public void UpdateNavMesh()
    {
        // NavMesh 다시 빌드
        navMeshSurface.BuildNavMesh();
    }
}
