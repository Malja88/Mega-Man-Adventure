using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAppearScript : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        obstacle.SetActive(true);
    }
}
