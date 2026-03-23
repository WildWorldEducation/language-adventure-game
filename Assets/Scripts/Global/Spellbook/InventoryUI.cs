using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject cardPrefab;
    public Transform container;

    public void ShowInventory()
    {
        foreach (Transform child in container)
            Destroy(child.gameObject);

        var cards = PlayerManager.Instance.playerData.cards;

        foreach (var card in cards)
        {
            var obj = Instantiate(cardPrefab, container);
            //   obj.GetComponent<CardUI>().Setup(card);
        }
    }
}