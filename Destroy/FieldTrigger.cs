using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldTrigger : MonoBehaviour
{
    public string excludeTag = "Weapon";
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(excludeTag))
        {
            return;
        }
        StartCoroutine(FadeOutAndDestroy(collision.gameObject));
    }

    private IEnumerator FadeOutAndDestroy(GameObject obj)
    {
        Renderer renderer = obj.GetComponent<Renderer>();
        if (renderer == null)
        {
            yield break;
        }

        Color originalColor = renderer.material.color;
        float fadeDuration = 2.0f;  // 2초 동안 서서히 사라지도록 설정

        for (float t = 0.0f; t < fadeDuration; t += Time.deltaTime)
        {
            Color newColor = originalColor;
            newColor.a = Mathf.Lerp(1, 0, t / fadeDuration);
            renderer.material.color = newColor;
            yield return null;
        }

        renderer.material.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0);
        Destroy(obj);
    }
}
