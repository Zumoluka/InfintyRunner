using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int currentScore = 0;

    // Multiplicador de puntos actual
    private int pointsMultiplier = 1;

    // Referencia al texto que muestra la puntuaci�n en la interfaz de usuario
    public TextMeshProUGUI scoreText;

    // M�todo para a�adir puntos al marcador
    public void AddPoints(int points)
    {
        // A�adir puntos multiplicados por el multiplicador actual
        currentScore += points * pointsMultiplier;

        // Actualizar el texto en la interfaz de usuario
        UpdateScoreText();
    }

    // M�todo para establecer el multiplicador de puntos
    public void SetPointsMultiplier(int multiplier)
    {
        pointsMultiplier = multiplier;
        Debug.Log("3");
    }

    // M�todo para restablecer el multiplicador de puntos a su valor normal
    public void ResetPointsMultiplier()
    {
        pointsMultiplier = 1;
    }

    // M�todo para actualizar el texto de puntuaci�n en la interfaz de usuario
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Puntuaci�n: " + currentScore.ToString();
        }
    }
}
