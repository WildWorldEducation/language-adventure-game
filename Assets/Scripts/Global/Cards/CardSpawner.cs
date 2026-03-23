using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    public Transform spawnPoint;

    public void ShowCards()
    {
        var cards = PlayerManager.Instance.playerData.cards;

        foreach (var card in cards)
        {
            //       Instantiate(card.prefab, spawnPoint.position, Quaternion.identity);
        }
    }
}