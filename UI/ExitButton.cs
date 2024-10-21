using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitButton : MonoBehaviour
{
    public void OnButtonlick()
    {
        Time.timeScale = 1; // 시간 스케일을 원래대로 복원
        SceneManager.LoadScene("Start");
    }
}
