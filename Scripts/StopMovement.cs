using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D movement;
    [SerializeField] Collider2D col;
    private void OnTriggerStay2D(Collider2D collision)
    {
        StopMove();
    }

    public void StopMove()
    {
        movement.constraints = RigidbodyConstraints2D.FreezePosition;
        col.isTrigger = true;
    }
}
