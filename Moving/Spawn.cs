using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject rangeObject;
    BoxCollider rangeCollider;

    private void Awake()
    {
        rangeCollider = rangeObject.GetComponent<BoxCollider>();
    }

    Vector3 Return_RandomPosition()
    {
        Vector3 originPosition = rangeObject.transform.position;
        // 콜라이더의 사이즈를 가져오는 bound.size 사용
        float range_X = rangeCollider.bounds.size.x;
        float range_Y = rangeCollider.bounds.size.y;

        range_X = UnityEngine.Random.Range((range_X / 2) * -1, range_X / 2);
        range_Y = UnityEngine.Random.Range((range_Y / 2) * -1, range_Y / 2);
        Vector3 RandomPostion = new Vector3(range_X,range_Y, 0f);

        Vector3 respawnPosition = originPosition + RandomPostion;
        return respawnPosition;
    }
    public GameObject capsul1;
    public GameObject capsul3;
    public GameObject capsul2;  

    private void Start()
    {
        StartCoroutine(RandomRespawn_Coroutine());
    }

    IEnumerator RandomRespawn_Coroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

            // 생성 위치 부분에 위에서 만든 함수 Return_RandomPosition() 함수 대입
            GameObject instantCapsul1 = Instantiate(capsul1, Return_RandomPosition(), Quaternion.Euler(90f, 0f, 0f));

            GameObject instantCapsul2 = Instantiate(capsul2, Return_RandomPosition(), Quaternion.Euler(90f, 0f, 0f));

            GameObject instantCapsul3 = Instantiate(capsul3, Return_RandomPosition(), Quaternion.Euler(90f, 0f, 0f));
        }
    }
}

