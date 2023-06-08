using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    [SerializeField] GameObject[] snowBall;
    [SerializeField] Transform[] snowballPoint;
    float interval = 2.5f;
    float timer;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            timer += Time.deltaTime;
            if (timer >= interval)
            {
                for(int i = 0; i < snowballPoint.Length; i++)
                {
                    for(int j = 0; j < snowBall.Length; i++)
                    {
                        Instantiate(snowBall[j], snowballPoint[i].position, Quaternion.identity);
                        timer -= interval;
                    }
                   
                }
            }
        }

    }
}
