using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("1 point earn");
            
            PlayerController player = GameObject.FindFirstObjectByType<PlayerController>();
            player.AddScore();

            gameObject.SetActive(false);
        }
    }
}
