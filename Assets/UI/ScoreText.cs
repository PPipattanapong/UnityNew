using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private PlayerController playerData;

    //PlayerController player;

    private void Start()
    {
        //text = GetComponent<TMP_Text>();
        //player = GameObject.FindFirstObjectByType<PlayerController>();


    }

    void Update()
    {
        text.text = playerData.GetScore().ToString();
    }
}
