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
            // �浹�� ��ü�� Rigidbody�� ���� ��쿡�� Rigidbody �߰�
            if (!GetComponent<Rigidbody>())
            {
                Rigidbody rb = gameObject.AddComponent<Rigidbody>();
                // Rigidbody �߰� �� ������ ������ �ִٸ� ���⿡ �߰�
            }
        }

        if (coll.gameObject.CompareTag("WALL"))
        {
            // �浹�� ������Ʈ ����
            Destroy(gameObject);
        }
    }
}