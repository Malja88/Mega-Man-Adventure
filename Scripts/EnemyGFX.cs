using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    [SerializeField] AIPath aiPath;

    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1.8f, 1.8f, 1.8f);
        }
        else if(aiPath.desiredVelocity.x <= 0.01f)
        {
            transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
        }
    }
}
