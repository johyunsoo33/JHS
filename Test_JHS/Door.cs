using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject[] leftmovableObjects;
    public GameObject[] rightmovableObjects;

    public Vector3 rightmoveDirection = new Vector3(0, 0, -2);
    public Vector3 leftmoveDirection = new Vector3(0, 0, 2);
    public float moveDistance = 1.0f;
    public float moveDuration = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        // 게임 시작과 동시에 문 열리기
        StartCoroutine(MoveObject());
    }

    // Update is called once per frame
    void Update()
    {
        // Fire 이름을 가진 오브젝트들이 있는지 확인
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        bool fireObjectExists = false;

        foreach (GameObject obj in allObjects)
        {
            if (obj.name == "LargeFlames(Clone)")
            {
                fireObjectExists = true;
                break;
            }
        }

        // 디버그 로그 추가
        Debug.Log("Fire object exists: " + fireObjectExists);

        // Fire 이름을 가진 오브젝트가 없는 경우에만 실행
        if (!fireObjectExists)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Mouse button clicked");

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    Debug.Log("Raycast hit something");

                    if (hit.transform == transform)
                    {
                        Debug.Log("Raycast hit the target transform");
                        StartCoroutine(MoveObject());
                    }
                }
                else
                {
                    Debug.Log("Raycast did not hit anything");
                }
            }
        }
        else
        {
            Debug.Log("Fire objects found, action blocked");
        }
    }


    IEnumerator MoveObject()
    {
        Vector3[] leftStartPositions = new Vector3[leftmovableObjects.Length];
        Vector3[] rightStartPositions = new Vector3[rightmovableObjects.Length];
        Vector3[] leftEndPositions = new Vector3[leftmovableObjects.Length];
        Vector3[] rightEndPositions = new Vector3[rightmovableObjects.Length];

        for (int i = 0; i < leftmovableObjects.Length; i++)
        {
            leftStartPositions[i] = leftmovableObjects[i].transform.position;
            leftEndPositions[i] = leftStartPositions[i] + (leftmoveDirection * moveDistance);
        }

        for (int i = 0; i < rightmovableObjects.Length; i++)
        {
            rightStartPositions[i] = rightmovableObjects[i].transform.position;
            rightEndPositions[i] = rightStartPositions[i] + (rightmoveDirection * moveDistance);
        }

        float elapsedTime = 0;
        float timeToReturn = 5f; // 이동 후 되돌아갈 시간

        while (elapsedTime < moveDuration)
        {
            for (int i = 0; i < leftmovableObjects.Length; i++)
            {
                leftmovableObjects[i].transform.position = Vector3.Lerp(leftStartPositions[i], leftEndPositions[i], elapsedTime / moveDuration);
            }

            for (int i = 0; i < rightmovableObjects.Length; i++)
            {
                rightmovableObjects[i].transform.position = Vector3.Lerp(rightStartPositions[i], rightEndPositions[i], elapsedTime / moveDuration);
            }

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 이동 완료 후 대기
        yield return new WaitForSeconds(timeToReturn);

        // 되돌아가기
        float returnDuration = 1.0f; // 되돌아가는 시간
        float returnElapsedTime = 0;

        while (returnElapsedTime < returnDuration)
        {
            for (int i = 0; i < leftmovableObjects.Length; i++)
            {
                leftmovableObjects[i].transform.position = Vector3.Lerp(leftEndPositions[i], leftStartPositions[i], returnElapsedTime / returnDuration);
            }

            for (int i = 0; i < rightmovableObjects.Length; i++)
            {
                rightmovableObjects[i].transform.position = Vector3.Lerp(rightEndPositions[i], rightStartPositions[i], returnElapsedTime / returnDuration);
            }

            returnElapsedTime += Time.deltaTime;
            yield return null;
        }

        // 되돌아가기 완료 후 최종 위치 설정
        for (int i = 0; i < leftmovableObjects.Length; i++)
        {
            leftmovableObjects[i].transform.position = leftStartPositions[i];
        }

        for (int i = 0; i < rightmovableObjects.Length; i++)
        {
            rightmovableObjects[i].transform.position = rightStartPositions[i];
        }
    }
}
