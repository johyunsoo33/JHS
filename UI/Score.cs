using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    // �浹�� ������Ʈ�� �����ϴ� HashSet
    private HashSet<GameObject> collidedObjects = new HashSet<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "점수는: " + score;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Slicable")
        {
            // �̹� �浹�� ������Ʈ���� Ȯ��
            if (!collidedObjects.Contains(collision.gameObject))
            {
                IncreaseScore();
                collidedObjects.Add(collision.gameObject);
            }
        }
    }
   

    private void IncreaseScore()
    {
        score++;
        UpdateScoreText();
    }
}