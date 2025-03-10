using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollector : MonoBehaviour
{
    public static CoinCollector Instance;

    private int totalCoins = 8;
    private int currentCoins = 0;

    private void Awake()
    {
       
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CollectCoin()
    {
        currentCoins++;
        Debug.Log("Monedas recolectadas: " + currentCoins + "/" + totalCoins);

        if (currentCoins >= totalCoins)
        {
            WinGame();
        }
    }

    private void WinGame()
    {
        SceneManager.LoadScene("Win");
       
    }
}
