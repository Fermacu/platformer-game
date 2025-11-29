using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Player player;

    [Header("Fruits Management")]
    public bool fruitHaveRandomLook;
    public int fruitsCollected;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void AddFruit() => fruitsCollected++;
    public bool FruitHasRandomLook() => fruitHaveRandomLook;
}