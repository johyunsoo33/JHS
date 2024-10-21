using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEx : MonoBehaviour
{
    public GameObject steamPrefab; // 파티클 프리팹
    private GameObject steamInstance; // 생성된 파티클 인스턴스
    private ParticleSystem steamParticleSystem; // 파티클 시스템
    private bool isSteamActive = false; // 파티클 활성 상태
    private bool isActive = false; // FireEx 활성 상태

    void Update()
    {
        if (!isActive) return; // 활성화되지 않은 경우 작동하지 않음

        // 마우스 우클릭을 유지하고 있는 경우
        if (Input.GetMouseButton(1))
        {
            if (!isSteamActive)
            {
                StartSteam();
            }
        }
        else
        {
            if (isSteamActive)
            {
                StopSteam();
            }
        }
    }

    public void StartSteam()
    {
        Vector3 position = transform.position + new Vector3(0, 1f, 0); // Y축으로 1 높게
        Quaternion rotation = transform.rotation * Quaternion.Euler(60, 90, 0); // 회전
        steamInstance = Instantiate(steamPrefab, position, rotation, transform);
        steamParticleSystem = steamInstance.GetComponent<ParticleSystem>();
        isSteamActive = true;

        // 파티클 생성시 FireController 스크립트를 추가합니다.
        steamInstance.AddComponent<FireController>();
    }

    public void StopSteam()
    {
        if (steamParticleSystem != null)
        {
            steamParticleSystem.Stop();
            Destroy(steamInstance, steamParticleSystem.main.startLifetime.constantMax);
        }
        isSteamActive = false;
    }


    public void Activate()
    {
        isActive = true;
    }

}
