using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 30f;
    [SerializeField] private PlayerData playerData;
    [SerializeField] private SoundLibrary soundLibrary;
    [SerializeField] private AudioClip Clip;


    private Rigidbody rb;

    public void AddScore()
    {
        playerData.score = playerData.score + 1;
        AudioSource.PlayClipAtPoint(soundLibrary.CoinClip, transform.position);

    }

    public void AddKey()
    {
        playerData.key = playerData.key + 1;
        AudioSource.PlayClipAtPoint(soundLibrary.KeyClip, transform.position);
    }

    public int GetScore()
    { 
        return playerData.score;
    }

    public int GetKey()
    {
        return playerData.key;
    }

    private void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    private void Update()
    {

        if (playerData.key == 3)
        {
            SceneManager.LoadScene(0);
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
