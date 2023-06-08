using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearingPlatforms : MonoBehaviour
{
    [SerializeField] float interval;
    float timer = 0;
    public bool enabled = true;
    private void Start()
    {
       enabled = true;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            timer -= interval;
            DisPlatform();
        }
    }

    void DisPlatform()
    {
        enabled = !enabled;
        foreach(Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(enabled);
        }    
    }
}
