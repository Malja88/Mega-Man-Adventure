using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowNumberStage : MonoBehaviour
{
    [SerializeField] private GameObject stage;
    [SerializeField] private GameObject healthBar;
    void Start()
    {
        stage.SetActive(true);
        healthBar.SetActive(true);
        StartCoroutine(StageShow());
    }
    private IEnumerator StageShow()
    {
        yield return new WaitForSeconds(2);
        stage.SetActive(false);
    }
}
