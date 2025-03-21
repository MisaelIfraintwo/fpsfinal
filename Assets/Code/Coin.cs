using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinCollector.Instance.CollectCoin();
            Destroy(gameObject);
        }
    }
}
