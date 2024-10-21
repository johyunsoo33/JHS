using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peddlerScipt : MonoBehaviour
{

    Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("NPCM", true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                // �� ������ ���� (�浹 �ݴ� �������� �÷��̾ �б�)
                Vector3 forceDirection = collision.transform.position - transform.position;
                forceDirection.y = 0; // y�� �̵� �����Ͽ� �������θ� �б�
                forceDirection.Normalize(); // ���� ���͸� ���� ���ͷ� ����

                float pushDistance = 2f; // �з����� �Ÿ� ����
                Vector3 newPosition = playerRigidbody.position + forceDirection * pushDistance;

                playerRigidbody.MovePosition(newPosition);
            }
        }
    }

}
