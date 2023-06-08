using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliderScript : MonoBehaviour
{
    [SerializeField] SliderJoint2D sliderJoint;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            sliderJoint.useMotor = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            sliderJoint.useMotor = false;
        }
    }
}
