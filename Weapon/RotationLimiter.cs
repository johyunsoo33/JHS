using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLimiter : MonoBehaviour
{
    public float minX = -45f; // �ּ� x�� ����
    public float maxX = 45f;  // �ִ� x�� ����

    public float minY = -45f; // �ּ� y�� ����
    public float maxY = 45f;  // �ִ� y�� ����
    public float minZ = -45f; // �ּ� z�� ����
    public float maxZ = 45f;  // �ִ� z�� ����

    private Rigidbody rb;
    private Quaternion initialRotation;

    void Start()
    {
        // ���� ������ٵ� ������Ʈ�� �����ɴϴ�.
        rb = GetComponent<Rigidbody>();
        initialRotation = transform.rotation;
    }

    void FixedUpdate()
    {
        // ���� ȸ�� ������ �ʱ� ȸ�� ���� ��������� ����մϴ�.
        Quaternion currentRotation = Quaternion.Inverse(initialRotation) * rb.rotation;
        Vector3 currentEulerAngles = currentRotation.eulerAngles;

        // x�� ȸ�� ������ ����
        if (currentEulerAngles.x > 180)
            currentEulerAngles.x -= 360;
        currentEulerAngles.x = Mathf.Clamp(currentEulerAngles.x, minX, maxX);

        // y�� ȸ�� ������ ����
        if (currentEulerAngles.y > 180)
            currentEulerAngles.y -= 360;
        currentEulerAngles.y = Mathf.Clamp(currentEulerAngles.y, minY, maxY);

        // z�� ȸ�� ������ ����
        if (currentEulerAngles.z > 180)
            currentEulerAngles.z -= 360;
        currentEulerAngles.z = Mathf.Clamp(currentEulerAngles.z, minZ, maxZ);

        // ���ѵ� ȸ�� ���� �ʱ� ȸ�� ���� ��������� ����Ͽ� �����մϴ�.
        Quaternion limitedRotation = initialRotation * Quaternion.Euler(currentEulerAngles);

        // ������ٵ��� ȸ���� ���ѵ� ȸ�� ������ �����մϴ�.
        rb.MoveRotation(limitedRotation);
    }
}
