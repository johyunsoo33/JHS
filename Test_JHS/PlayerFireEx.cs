using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireEx : MonoBehaviour
{
    public GameObject objectToPlace;
    private bool shouldFollowGun = false;
    private bool isInTrigger = false;
    public FireEx fireExScript;
    public GameObject Deleteobj; // ö�� ���� ����

    void Update()
    {
        if (isInTrigger && Input.GetKeyDown(KeyCode.F))
        {
            PlaceObjectAtGunPosition();
            shouldFollowGun = true;

            // Deleteobj�� ������ ��� ����
            if (Deleteobj != null)
            {
                Destroy(Deleteobj);
            }

            // FireEx ��ũ��Ʈ Ȱ��ȭ
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

                // CharMove ������Ʈ�� ã�� speed�� 2���� ����
                CharMove charMove = player.GetComponent<CharMove>();
                if (charMove != null)
                {
                    charMove.SetSpeed(2f);
                }
            }
            else
            {
                Debug.LogError("Gun ������Ʈ�� ã�� �� �����ϴ�.");
            }
        }
        else
        {
            Debug.LogError("Player �±׸� ���� ������Ʈ�� ã�� �� �����ϴ�.");
        }
    }
}
