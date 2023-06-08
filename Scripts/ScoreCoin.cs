using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCoin : MonoBehaviour
{
    public int coins;
    [SerializeField] Text score;
    [SerializeField] Text stageScore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            coins += 1;
            score.text = coins.ToString();
            stageScore.text = coins.ToString();
            Destroy(collision.gameObject);
        }
    }
}
