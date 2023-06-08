using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlyingObjects : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] Rigidbody2D rb;
    private void Start()
    {
        rb.velocity = new Vector2 (speed * -1, rb.velocity.y);
    }
}
