using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        if (CoinCounter.instance != null)
            CoinCounter.instance.AddCoin(); // Safe call

        if (AudioManager.instance != null)
    AudioManager.instance.Play("coinsound");

        Destroy(gameObject);
    }
}

}
