using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Character")]
[System.Serializable]
public class CharacterSO : ScriptableObject
{
    public string NPCName;
    public Sprite NPCSprite;
    public Dialogue positiveResponse;
    public Dialogue negativeResponse;
    public AudioClip voice;
    
}
