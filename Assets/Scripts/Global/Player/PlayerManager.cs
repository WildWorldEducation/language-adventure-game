using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    public PlayerData playerData = new PlayerData();
    public CardSpawner cardSpawner;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // KEY LINE
        }
        else
        {
            Destroy(gameObject);
        }

        if (cardSpawner != null)
        {
            cardSpawner.ShowCards();
        }
    }
}