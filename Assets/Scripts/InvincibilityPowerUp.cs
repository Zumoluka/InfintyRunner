using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InvincibilityPowerUp : MonoBehaviour
{
    /*public float invincibilityDuration = 10f;

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que choc� es el jugador
        if (other.CompareTag("Player"))
        {
            // Desactivar el collider del jugador para evitar que se active m�ltiples veces
            other.GetComponent<Collider>().enabled = false;

            // Aplicar el power-up al jugador
            ApplyPowerUp(other.gameObject);
        }
    }

    private void ApplyPowerUp(GameObject player)
    {
        // Activar la invulnerabilidad en el jugador
        PlayerMovement playerController = player.GetComponent<PlayerMovement>();
        if (playerController != null)
        {
            playerController.ActivateInvincibility(invincibilityDuration);
        }

        // Destruir el GameObject del power-up
        Destroy(gameObject);
    }*/
    // Referencia al collider del objeto a desactivar
    /*public Collider objectCollider;

    private bool powerUpActive = false;

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el jugador (u otro objeto) entra en contacto con el power up
        if (other.CompareTag("Player") && powerUpActive) // Ajusta la etiqueta seg�n corresponda
        {
            // Desactiva el collider del objeto espec�fico
            objectCollider.enabled = false;

            // Inicia la cuenta regresiva para volver a activar el collider despu�s de 5 segundos
            Invoke("ReactivateCollider", 5f);
            Debug.Log("Si");
            // Destruye el power up
            Destroy(gameObject);
        }
    }

    // M�todo para reactivar el collider despu�s de 5 segundos
    private void ReactivateCollider()
    {
        objectCollider.enabled = true;
    }*/
    // Tiempo durante el cual el power up est� activo
    public float powerUpDuration = 10f;
    // Factor de multiplicaci�n para los puntos
    public int pointsMultiplier = 2;

    // Referencia al efecto visual del power up
    public GameObject powerUpEffect;

    // M�todo para activar el power up
    public void ActivatePowerUp()
    {
        Debug.Log("1");
        // Buscar el ScoreManager en la escena
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        Debug.Log("2");
        // Verificar si se encontr� el ScoreManager
        if (scoreManager != null)
        {
            // Duplicar la puntuaci�n durante el tiempo especificado
            scoreManager.SetPointsMultiplier(pointsMultiplier);

            // Mostrar el efecto visual del power up
            if (powerUpEffect != null)
            {
                Instantiate(powerUpEffect, transform.position, Quaternion.identity);
            }

            // Desactivar el power up despu�s de cierto tiempo
            Invoke("DeactivatePowerUp", powerUpDuration);
        }
        else
        {
            Debug.LogError("ScoreManager no encontrado en la escena.");
        }
    }

    // M�todo para desactivar el power up
    private void DeactivatePowerUp()
    {
        // Buscar el ScoreManager en la escena
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();

        // Verificar si se encontr� el ScoreManager
        if (scoreManager != null)
        {
            // Restaurar el multiplicador de puntos a su valor normal
            scoreManager.ResetPointsMultiplier();

            // Destruir el objeto del power up
            Destroy(gameObject);
        }
        else
        {
            Debug.LogError("ScoreManager no encontrado en la escena.");
        }
    }

    // M�todo para manejar la colisi�n con el jugador
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entre");
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            // Activar el power up cuando el jugador colisiona con �l
            ActivatePowerUp();
            
        }
    }
}
