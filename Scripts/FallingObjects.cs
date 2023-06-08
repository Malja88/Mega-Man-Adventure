using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    [SerializeField] GameObject snowBall;
    [SerializeField] Transform snowballPoint;
    [SerializeField] float interval;
    float timer;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            timer += Time.deltaTime;
            if(timer >= interval)
            {
                Instantiate(snowBall, snowballPoint.position, Quaternion.identity);
                timer -= interval;
            }
        }
       
    }
}
