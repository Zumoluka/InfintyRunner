using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    int score;
    public static GameManager inst;
    //[SerializeField] Text scoreText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] PlayerMovement playerMovement;
    //[SerializeField] int pointsMultiplier = 1;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
        playerMovement.speed += playerMovement.speedIncreasePerPoint;
    }
    private void Awake()
    {
        inst = this;
    }
   /* public void SetPointsMultiplier(int multiplier)
    {
        pointsMultiplier = multiplier;
    }
    public void ResetPointsMultiplier()
    {
        pointsMultiplier = 1;
    }*/
}
