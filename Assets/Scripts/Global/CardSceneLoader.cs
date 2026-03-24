using UnityEngine;

public class CardSceneLoader : MonoBehaviour
{
    public float spacing = 120f; // pixels
    public float margin = 60f;

    void Start()
    {
        ShowCards();
    }

    public void ShowCards()
    {
        var cards = PlayerManager.Instance.playerData.cards;

        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        float x = margin;
        float y = screenHeight - margin;

        int perRow = Mathf.FloorToInt((screenWidth - margin * 2) / spacing);

        for (int i = 0; i < cards.Count; i++)
        {
            Vector3 screenPos = new Vector3(x, y, 5f);
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);

            Instantiate(cards[i].prefab, worldPos, Quaternion.identity);

            x += spacing;

            // wrap to next row
            if ((i + 1) % perRow == 0)
            {
                x = margin;
                y -= spacing;
            }
        }
    }

    Vector3 ScreenToWorld(Vector3 screenPos)
    {
        screenPos.z = 5f; // distance from camera (adjust!)
        return Camera.main.ScreenToWorldPoint(screenPos);
    }
}