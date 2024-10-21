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
    public float delayBeforeSpawn = 13f; // 불이 생성되기 전 대기 시간
    public Transform parentObject; // 부모 오브젝트
    public GameObject objectToDestroy; // 할당할 오브젝트
    public peddlerFollow navMeshUpdater; // NavMeshUpdater 컴포넌트 참조
    private GameTimer gameTimer; // GameTimer 객체 참조

    void Start()
    {
        // GameTimer 객체를 찾습니다.
        gameTimer = FindObjectOfType<GameTimer>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Player 태그를 가진 게임오브젝트와 충돌한 경우
        if (other.CompareTag("Player"))
        {
            // 타이머를 시작합니다.
            if (gameTimer != null && !gameTimer.IsGameActive())
            {
                gameTimer.StartTimer();

                // 오브젝트를 파괴합니다.
                if (objectToDestroy != null)
                {
                    Destroy(objectToDestroy);
                }
            }

            // 13초 후에 불을 생성하는 코루틴 시작
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
        // NavMeshObstacle 컴포넌트를 추가하여 네브메쉬에서 장애물로 인식되도록 설정합니다.
        NavMeshObstacle obstacle = fireInstance.AddComponent<NavMeshObstacle>();
        obstacle.carving = true;  // 장애물 영역을 네브메쉬에서 제외

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
