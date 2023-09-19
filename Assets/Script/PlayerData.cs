using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

[CreateAssetMenu(menuName = "WOWDataObject/Sharedata")]

public class PlayerData : ScriptableObject
{
    public int score = 0;
    public int key = 0;
}

