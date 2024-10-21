using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityMode : MonoBehaviour
{
    public GameObject rangeObject;
    private BoxCollider rangeCollider;

    public GameObject capsul1;
    public GameObject capsul2;
    public GameObject capsul3;

    // ���ƿ��� ������Ʈ�� ���� ������ �� �ִ� ����
    public int numberOfObjects = 3;

    private void Awake()
    {
        rangeCollider = rangeObject.GetComponent<BoxCollider>();
    }

    private void Start()
    {
        StartCoroutine(RandomRespawn_Coroutine());
    }

    Vector3 Return_RandomPosition()
    {
        Vector3 originPosition = rangeObject.transform.position;
        float range_X = rangeCollider.bounds.size.x;
        float range_Y = rangeCollider.bounds.size.y;

        range_X = UnityEngine.Random.Range((range_X / 2) * -1, range_X / 2);
        range_Y = UnityEngine.Random.Range((range_Y / 2) * -1, range_Y / 2);
        Vector3 RandomPosition = new Vector3(range_X, range_Y, 0f);

        Vector3 respawnPosition = originPosition + RandomPosition;
        return respawnPosition;
    }

    IEnumerator RandomRespawn_Coroutine()
    {
        GameObject[] capsules = new GameObject[] { capsul1, capsul2, capsul3 };

        while (true)
        {
            yield return new WaitForSeconds(2.5f);

            List<Vector3> positions = new List<Vector3>();

            for (int i = 0; i < numberOfObjects; i++)
            {
                Vector3 newPosition;
                do
                {
                    newPosition = Return_RandomPosition();
                } while (!IsValidPosition(newPosition, positions));

                positions.Add(newPosition);
            }

            for (int i = 0; i < positions.Count; i++)
            {
                GameObject capsule = capsules[UnityEngine.Random.Range(0, capsules.Length)];
                Instantiate(capsule, positions[i], Quaternion.Euler(90f, 0f, 0f));
            }
        }
    }

    bool IsValidPosition(Vector3 newPosition, List<Vector3> existingPositions)
    {
        foreach (Vector3 pos in existingPositions)
        {
            if (Vector3.Distance(newPosition, pos) < 1f)
                return false;
        }
        return true;
    }
}
