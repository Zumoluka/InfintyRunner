using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int currentScore = 0;

    // Multiplicador de puntos actual
    private int pointsMultiplier = 1;

    // Referencia al texto que muestra la puntuación en la interfaz de usuario
    public TextMeshProUGUI scoreText;

    // Método para añadir puntos al marcador
    public void AddPoints(int points)
    {
        // Añadir puntos multiplicados por el multiplicador actual
        currentScore += points * pointsMultiplier;

        // Actualizar el texto en la interfaz de usuario
        UpdateScoreText();
    }

    // Método para establecer el multiplicador de puntos
    public void SetPointsMultiplier(int multiplier)
    {
        pointsMultiplier = multiplier;
        Debug.Log("3");
    }

    // Método para restablecer el multiplicador de puntos a su valor normal
    public void ResetPointsMultiplier()
    {
        pointsMultiplier = 1;
    }

    // Método para actualizar el texto de puntuación en la interfaz de usuario
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Puntuación: " + currentScore.ToString();
        }
    }
}
