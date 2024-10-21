using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLimiter : MonoBehaviour
{
    public float minX = -45f; // 최소 x축 각도
    public float maxX = 45f;  // 최대 x축 각도

    public float minY = -45f; // 최소 y축 각도
    public float maxY = 45f;  // 최대 y축 각도
    public float minZ = -45f; // 최소 z축 각도
    public float maxZ = 45f;  // 최대 z축 각도

    private Rigidbody rb;
    private Quaternion initialRotation;

    void Start()
    {
        // 기존 리지드바디 컴포넌트를 가져옵니다.
        rb = GetComponent<Rigidbody>();
        initialRotation = transform.rotation;
    }

    void FixedUpdate()
    {
        // 현재 회전 각도를 초기 회전 값에 상대적으로 계산합니다.
        Quaternion currentRotation = Quaternion.Inverse(initialRotation) * rb.rotation;
        Vector3 currentEulerAngles = currentRotation.eulerAngles;

        // x축 회전 각도를 제한
        if (currentEulerAngles.x > 180)
            currentEulerAngles.x -= 360;
        currentEulerAngles.x = Mathf.Clamp(currentEulerAngles.x, minX, maxX);

        // y축 회전 각도를 제한
        if (currentEulerAngles.y > 180)
            currentEulerAngles.y -= 360;
        currentEulerAngles.y = Mathf.Clamp(currentEulerAngles.y, minY, maxY);

        // z축 회전 각도를 제한
        if (currentEulerAngles.z > 180)
            currentEulerAngles.z -= 360;
        currentEulerAngles.z = Mathf.Clamp(currentEulerAngles.z, minZ, maxZ);

        // 제한된 회전 값을 초기 회전 값에 상대적으로 계산하여 적용합니다.
        Quaternion limitedRotation = initialRotation * Quaternion.Euler(currentEulerAngles);

        // 리지드바디의 회전을 제한된 회전 값으로 설정합니다.
        rb.MoveRotation(limitedRotation);
    }
}
