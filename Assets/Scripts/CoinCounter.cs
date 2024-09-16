using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter Instance;
    public TMP_Text coinText;
    public int currentCoins = 0;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "COINS: " + currentCoins;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseCoins(int v)
    {
        currentCoins += v;  
        coinText.text = "COINS: " + currentCoins.ToString();
    }
}
