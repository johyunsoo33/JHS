using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFirePas : MonoBehaviour
{ // 특정 오브젝트의 태그를 저장합니다.
    public string specificObjectTag = "Fire";

    void OnCollisionEnter(Collision collision)
    {
        // 충돌한 오브젝트가 특정 오브젝트인지 확인합니다.
        if (collision.gameObject.CompareTag(specificObjectTag))
        {
            // 플레이어와 특정 오브젝트의 콜라이더 간의 충돌을 무시하도록 설정합니다.
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>(), true);
        }
    }

}
