using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class peddlerFollow : MonoBehaviour
{
    public NavMeshSurface navMeshSurface;  // �׺�޽��� ����� NavMeshSurface ������Ʈ

    // �� �Լ��� �ٸ� ��ũ��Ʈ���� ȣ��� �� ����
    public void UpdateNavMesh()
    {
        // NavMesh �ٽ� ����
        navMeshSurface.BuildNavMesh();
    }
}
