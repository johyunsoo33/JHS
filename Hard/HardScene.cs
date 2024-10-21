using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
public class HardScene : MonoBehaviour
{
    public void OnButtonlick()
    { 
        SceneManager.LoadScene("Hard");
    }
}
