using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private bool hasPassedStart1 = false;
    private GameObject Start1;
    public GameObject ShowClearText;
    public GameObject ShowClearButton;

    void Start()
    {
        Start1 = GameObject.Find("Start1");
    }
    void Update()
    {
        if (!hasPassedStart1 && Start1 == null)
        {
            hasPassedStart1 = true;
            Debug.Log("Start1 object is no longer in the Hierarchy. Trigger is now active.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasPassedStart1 && other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            Debug.Log("Player has entered the trigger after passing Start1. Game paused.");
            ShowClearText.SetActive(true);
            ShowClearButton.SetActive(true);
        }
    }
}
