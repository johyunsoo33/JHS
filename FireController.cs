using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Fire"))
        {
            // 서서히 삭제하는 코루틴 시작
            StartCoroutine(FadeAndDestroy(other));
        }
    }

    private IEnumerator FadeAndDestroy(GameObject obj)
    {
        Renderer renderer = obj.GetComponent<Renderer> ();
        if (renderer != null)
        {
            
            Color color = renderer.material.color;

         
            for (float alpha = 3.5f; alpha > 0.0f; alpha -= 0.1f)
            {
               
                color.a = alpha;
                renderer.material.color = color;

               
                yield return new WaitForSeconds(0.1f);
            }
        }

        Destroy(obj);
    }
}
