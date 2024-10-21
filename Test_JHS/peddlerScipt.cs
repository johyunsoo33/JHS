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
                // 밀 방향을 결정 (충돌 반대 방향으로 플레이어를 밀기)
                Vector3 forceDirection = collision.transform.position - transform.position;
                forceDirection.y = 0; // y축 이동 제거하여 수평으로만 밀기
                forceDirection.Normalize(); // 방향 벡터를 단위 벡터로 만듦

                float pushDistance = 2f; // 밀려나는 거리 조정
                Vector3 newPosition = playerRigidbody.position + forceDirection * pushDistance;

                playerRigidbody.MovePosition(newPosition);
            }
        }
    }

}
