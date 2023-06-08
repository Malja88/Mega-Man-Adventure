using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticShooting : MonoBehaviour
{
    [SerializeField] float interval;
    [SerializeField] Shooter shoot;
    float timer;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= interval)
        {
            shoot.Shoot();
            timer -= interval;
        }
    }
}
