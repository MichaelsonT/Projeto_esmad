using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Player : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float rotationSpeed = 100f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            RotateLeft();
        }

        if (Input.GetKey(KeyCode.D))
        {
            RotateRight();
        }

        if (Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }

        if (Input.GetKey(KeyCode.S))
        {
            MoveBackward();
        }
    }

    void RotateLeft()
    {
        transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
    }

    void RotateRight()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void MoveForward()
    {
        Vector3 forwardDirection = transform.forward;
        rb.MovePosition(transform.position + forwardDirection * movementSpeed * Time.deltaTime);
    }

    void MoveBackward()
    {
        Vector3 backwardDirection = -transform.forward;
        rb.MovePosition(transform.position + backwardDirection * movementSpeed * Time.deltaTime);
    }
}
