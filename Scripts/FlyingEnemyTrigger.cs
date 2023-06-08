using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject[] _object;
    [SerializeField] private GameObject[] _body;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            for(int i = 0; i < _object.Length; i++)
            {
                _object[i].SetActive(true);
            }
            for(int i = 0; i < _body.Length; i++)
            {
                Destroy(_body[i]);
            }
        }  
    }
}
