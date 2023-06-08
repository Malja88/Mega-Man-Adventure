using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenBoard : MonoBehaviour
{
    [SerializeField] private GameObject board;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(board);
        }
    }
}
