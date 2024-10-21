using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;
using UnityEngine.AI;
public class FireSpawn : MonoBehaviour
{
    public GameObject firePrefab;
    public int minFireCount = 6;
    public int maxFireCount = 10;
    public BoxCollider spawnRange; // FireSpawnRange BoxCollider
    public float delayBeforeSpawn = 13f; // ���� �����Ǳ� �� ��� �ð�
    public Transform parentObject; // �θ� ������Ʈ
    public GameObject objectToDestroy; // �Ҵ��� ������Ʈ
    public peddlerFollow navMeshUpdater; // NavMeshUpdater ������Ʈ ����
    private GameTimer gameTimer; // GameTimer ��ü ����

    void Start()
    {
        // GameTimer ��ü�� ã���ϴ�.
        gameTimer = FindObjectOfType<GameTimer>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Player �±׸� ���� ���ӿ�����Ʈ�� �浹�� ���
        if (other.CompareTag("Player"))
        {
            // Ÿ�̸Ӹ� �����մϴ�.
            if (gameTimer != null && !gameTimer.IsGameActive())
            {
                gameTimer.StartTimer();

                // ������Ʈ�� �ı��մϴ�.
                if (objectToDestroy != null)
                {
                    Destroy(objectToDestroy);
                }
            }

            // 13�� �Ŀ� ���� �����ϴ� �ڷ�ƾ ����
            StartCoroutine(SpawnFireAfterDelay(delayBeforeSpawn));
        }
    }

    IEnumerator SpawnFireAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        int fireCount = Random.Range(minFireCount, maxFireCount);

        for (int i = 0; i < fireCount; i++)
        {
            SpawnFire(parentObject);
        }

        if (navMeshUpdater != null)
        {
            navMeshUpdater.UpdateNavMesh();
        }
        else
        {
            
        }
    }

    void SpawnFire(Transform parent)
    {
        Vector3 randomPosition = GetRandomPositionInBox(spawnRange);
        GameObject fireInstance = Instantiate(firePrefab, randomPosition, Quaternion.identity, parent);
        // NavMeshObstacle ������Ʈ�� �߰��Ͽ� �׺�޽����� ��ֹ��� �νĵǵ��� �����մϴ�.
        NavMeshObstacle obstacle = fireInstance.AddComponent<NavMeshObstacle>();
        obstacle.carving = true;  // ��ֹ� ������ �׺�޽����� ����

        fireInstance.AddComponent<FireController>();
    }

    Vector3 GetRandomPositionInBox(BoxCollider box)
    {
        Vector3 boxSize = box.size;
        Vector3 boxCenter = box.center;

        Vector3 randomPosition = new Vector3(
            Random.Range(boxCenter.x - boxSize.x / 2, boxCenter.x + boxSize.x / 2),
            Random.Range(boxCenter.y - boxSize.y / 2, boxCenter.y + boxSize.y / 2),
            Random.Range(boxCenter.z - boxSize.z / 2, boxCenter.z + boxSize.z / 2)
        );

        return box.transform.TransformPoint(randomPosition);
    }
}
