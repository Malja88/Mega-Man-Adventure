using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class MineScript : MonoBehaviour
{
    private Vector2 blast = new Vector2(0, 6);
    private sbyte force = 4;
    [SerializeField] Animator anim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(blast * force, ForceMode2D.Impulse);
            anim.SetTrigger("Kaboom");
            Destroy(gameObject);
        }
    }
}
