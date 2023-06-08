using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    [SerializeField] private GameObject boxes;
    [SerializeField] private GameObject explosionPoint;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wagon"))
        {
            explosionPoint.SetActive(true);
            StartCoroutine(DestroyBoxes());
        }
    }

    private IEnumerator DestroyBoxes()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(explosionPoint); 
        yield return new WaitForSeconds(3);
        Destroy(boxes);
    }
}
