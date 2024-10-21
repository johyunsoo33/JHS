using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HardEnd : MonoBehaviour
{
    private List<GameObject> lifeImages;
    public Text gameOverText;
    public Button Exit;
    // Start is called before the first frame update
    void Start()
    {
       
        gameOverText.gameObject.SetActive(false);
        Exit.gameObject.SetActive(false);

        lifeImages = new List<GameObject>(GameObject.FindGameObjectsWithTag("Life"));
    }
    // Update is called once per frame
        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Slicable"||other.gameObject.tag=="Wall")
        {
            Debug.Log("Triggered with Slicable. Destroying Slicable object.");
            Destroy(other.gameObject);

            // Life �̹����� �ϳ��� ��Ȱ��ȭ
            if (lifeImages.Count > 0)
            {
                GameObject lifeImage = lifeImages[0];
                lifeImages.RemoveAt(0);
                lifeImage.SetActive(false);

                // ��� Life �̹����� ��������� Ȯ��
                if (lifeImages.Count == 0)
                {
                    EndGame();
                }
            }
        }
    }


    void EndGame()
    {
        Debug.Log("���� ����");
        gameOverText.gameObject.SetActive(true);
        Exit.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
