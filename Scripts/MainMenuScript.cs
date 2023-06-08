using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private Animator transition;
    [SerializeField] private GameObject trans;
    public void StartGame()
    {
        StartCoroutine(LoadScene());
    }
    public void QuitGame()
    {
        Application.Quit();
    }

   private IEnumerator LoadScene()
    {
        trans.SetActive(true);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
