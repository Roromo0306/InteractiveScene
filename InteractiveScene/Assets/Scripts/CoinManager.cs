using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance; // Singleton para acceso global
    public TMP_Text coinText; // Referencia al texto en la UI
    private int coins = 0;
    public GameObject achieved;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        UpdateUI();
        achieved.SetActive(false);
    }

    private void Update()
    {
        if(coins == 6)
        {
            achieved.SetActive(true);   
        }
    }

    public void AddCoin(int amount)
    {
        coins += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        coinText.text = "COINS: " + coins;
    }
}
