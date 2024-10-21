using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conslinder : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Weapon"))
        {
            // 충돌한 물체에 Rigidbody가 없는 경우에만 Rigidbody 추가
            if (!GetComponent<Rigidbody>())
            {
                Rigidbody rb = gameObject.AddComponent<Rigidbody>();
                // Rigidbody 추가 후 설정할 내용이 있다면 여기에 추가
            }
        }

        if (coll.gameObject.CompareTag("WALL"))
        {
            // 충돌한 오브젝트 삭제
            Destroy(gameObject);
        }
    }
}