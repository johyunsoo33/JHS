using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEx : MonoBehaviour
{
    public GameObject steamPrefab; // ��ƼŬ ������
    private GameObject steamInstance; // ������ ��ƼŬ �ν��Ͻ�
    private ParticleSystem steamParticleSystem; // ��ƼŬ �ý���
    private bool isSteamActive = false; // ��ƼŬ Ȱ�� ����
    private bool isActive = false; // FireEx Ȱ�� ����

    void Update()
    {
        if (!isActive) return; // Ȱ��ȭ���� ���� ��� �۵����� ����

        // ���콺 ��Ŭ���� �����ϰ� �ִ� ���
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
        Vector3 position = transform.position + new Vector3(0, 1f, 0); // Y������ 1 ����
        Quaternion rotation = transform.rotation * Quaternion.Euler(60, 90, 0); // ȸ��
        steamInstance = Instantiate(steamPrefab, position, rotation, transform);
        steamParticleSystem = steamInstance.GetComponent<ParticleSystem>();
        isSteamActive = true;

        // ��ƼŬ ������ FireController ��ũ��Ʈ�� �߰��մϴ�.
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
