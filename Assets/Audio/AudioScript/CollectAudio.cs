using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAudio : MonoBehaviour
{
    public AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
