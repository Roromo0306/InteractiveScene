using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1; // Valor de la moneda

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Detecta si el jugador la toca
        {
            CoinManager.instance.AddCoin(coinValue); // Suma al contador
            Destroy(gameObject); // Elimina la moneda
        }
    }
}
