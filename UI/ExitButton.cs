using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitButton : MonoBehaviour
{
    public void OnButtonlick()
    {
        Time.timeScale = 1; // �ð� �������� ������� ����
        SceneManager.LoadScene("Start");
    }
}
