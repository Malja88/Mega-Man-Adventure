using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallDestroer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Snowball"))
        {
            Destroy(collision.gameObject);
        }
    }
}
