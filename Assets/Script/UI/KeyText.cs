using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyText : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private PlayerController player;

    void Start()
    {

    }

    void Update()
    {
        text.text = player.GetKey().ToString();
    }
}
