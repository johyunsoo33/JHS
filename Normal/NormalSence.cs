using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalSence : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Normal");
    }
}
