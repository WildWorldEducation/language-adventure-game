using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Game/Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public GameObject prefab;
    public Sprite icon;
}