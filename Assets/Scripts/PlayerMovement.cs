using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;
    private bool isInvincible = false;
    public float speed = 5;
    [SerializeField] Rigidbody rb;
    float horizontalInput;
    [SerializeField] float horizontalMultiplier = 2;
    public float speedIncreasePerPoint = 0.1f;

    private void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -5)
        {
            Die();
        }
        if(!isInvincible) 
        {
            float horizontalInmput = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3 (horizontalInput, 0, speed) * Time.deltaTime;
            rb.MovePosition(transform.position + movement);
        }
    }

    public void Die()
    {
        alive = false;

        Invoke("Restart", 1);
    }

    void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ActivateInvincibility(float duration)
    {
        isInvincible = true;

        Invoke("DeactivateInvincibility", duration);
    }

    private void DeactivateInvincibility()
    {
        isInvincible = false;
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void ActivateInvencibility(float duration)
    {
        isInvincible=true;
        Invoke("DeactivateInvencibility", duration);
    }
    public void DeactivateInvencibility()
    {
        isInvincible = false;
    }

}
