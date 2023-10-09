using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 25f;
    [SerializeField] private int score = 0;
    [SerializeField] private int key = 0;


    private Rigidbody rb;

    public void AddScore()
    {
        score = score + 1;
    }

    public void AddKey()
    {
        key = key + 1;
    }

    public int GetScore()
    { 
        return score;
    }

    public int GetKey()
    {
        return key;
    }

    private void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    private void Update()
    {

        if (key == 2)
        {
            SceneManager.LoadScene(1);
        }

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
