using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    [SerializeField] private Animator transition;
    [SerializeField] private GameObject trans;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private GameObject endOfRound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            rb.bodyType = RigidbodyType2D.Static;
            StartCoroutine(LoadScene());
        }
    }
    private IEnumerator LoadScene()
    {
        endOfRound.SetActive(true);
        yield return new WaitForSeconds(2);
        trans.SetActive(true);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
