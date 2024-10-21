using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireEx : MonoBehaviour
{
    public GameObject objectToPlace;
    private bool shouldFollowGun = false;
    private bool isInTrigger = false;
    public FireEx fireExScript;
    public GameObject Deleteobj; // 철자 오류 수정

    void Update()
    {
        if (isInTrigger && Input.GetKeyDown(KeyCode.F))
        {
            PlaceObjectAtGunPosition();
            shouldFollowGun = true;

            // Deleteobj가 존재할 경우 삭제
            if (Deleteobj != null)
            {
                Destroy(Deleteobj);
            }

            // FireEx 스크립트 활성화
            if (fireExScript != null)
            {
                fireExScript.Activate();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EX")
        {
            isInTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "EX")
        {
            isInTrigger = false;
        }
    }

    void PlaceObjectAtGunPosition()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            Transform gunTransform = player.transform.Find("Gun");
            if (gunTransform != null)
            {
                float originalXRotation = objectToPlace.transform.eulerAngles.x;

                objectToPlace.transform.SetParent(gunTransform);

                objectToPlace.transform.localPosition = Vector3.zero;

                Vector3 newRotation = gunTransform.eulerAngles;
                newRotation.x = originalXRotation;

                objectToPlace.transform.eulerAngles = newRotation;

                // CharMove 컴포넌트를 찾아 speed를 2으로 설정
                CharMove charMove = player.GetComponent<CharMove>();
                if (charMove != null)
                {
                    charMove.SetSpeed(2f);
                }
            }
            else
            {
                Debug.LogError("Gun 오브젝트를 찾을 수 없습니다.");
            }
        }
        else
        {
            Debug.LogError("Player 태그를 가진 오브젝트를 찾을 수 없습니다.");
        }
    }
}
