using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public GameObject targetObject;

    public Button targetButton;


    public void OnButtonClick()
    {
        // targetObject�� Ȱ��ȭ�մϴ�.
        targetObject.SetActive(true);

        // targetButton�� ��Ȱ��ȭ�մϴ�.
        targetButton.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
    }
}
