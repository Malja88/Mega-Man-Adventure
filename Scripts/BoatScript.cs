using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatScript : MonoBehaviour
{
    [SerializeField] private GameObject boat;
    [SerializeField] private GameObject boatMark;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        boat.SetActive(true);
        Destroy(boatMark);
    }

}
