using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Slicable"))
        {
            StartCoroutine(DestroyAfterDelay(collision.gameObject, 3f));
        }
    }

    private IEnumerator DestroyAfterDelay(GameObject objToDestroy, float delay)
    {
        yield return new WaitForSeconds(delay);

        Destroy(objToDestroy);
    }
}
