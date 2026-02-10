using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text myScoreText;
    private int scoreNum = 0;

    void Start()
    {
        myScoreText.text = "X " + scoreNum;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("mycoin"))
        {
            scoreNum += 5;
            Destroy(collision.gameObject);
            myScoreText.text = "X " + scoreNum;
        }
    }
}
