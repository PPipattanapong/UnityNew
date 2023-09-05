using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 40f;

    private Rigidbody rb;
    private void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float x = 0.0f;
        float y = 0.0f;

        if (Input.GetKey(KeyCode.A))
        {
            x = rotationSpeed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            x = -rotationSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            y = rotationSpeed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            y = -rotationSpeed * Time.deltaTime;
        }

        rb.AddTorque(y, 0, x);

    }
}
