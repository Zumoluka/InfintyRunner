using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()

    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(direction * force, ForceMode.Force);

    }
}
