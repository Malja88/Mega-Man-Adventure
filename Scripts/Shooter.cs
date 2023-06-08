using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;
    public void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }

}
