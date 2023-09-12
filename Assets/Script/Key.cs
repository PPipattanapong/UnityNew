using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Get Key");

            PlayerController player = GameObject.FindFirstObjectByType<PlayerController>();
            player.AddKey();

            gameObject.SetActive(false);
        }   
    }
}
