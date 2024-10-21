using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFirePas : MonoBehaviour
{ // Ư�� ������Ʈ�� �±׸� �����մϴ�.
    public string specificObjectTag = "Fire";

    void OnCollisionEnter(Collision collision)
    {
        // �浹�� ������Ʈ�� Ư�� ������Ʈ���� Ȯ���մϴ�.
        if (collision.gameObject.CompareTag(specificObjectTag))
        {
            // �÷��̾�� Ư�� ������Ʈ�� �ݶ��̴� ���� �浹�� �����ϵ��� �����մϴ�.
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>(), true);
        }
    }

}
