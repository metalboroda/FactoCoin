using System;
using UnityEngine;
using UnityEngine.UI;

public class CoinManagerScript : MonoBehaviour
{
    // Singleton
    public static CoinManagerScript Instance { get; private set; }


    public int coin1Value;
    public Text coin1Text;
    public int coin2Value;
    public Text coin2Text;

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

    private void Start()
    {
        coin1Value = PlayerPrefs.GetInt("coin1Value");
        coin2Value = PlayerPrefs.GetInt("coin2Value");
    }

    private void Update()
    {
        coin1Text.text = coin1Value.ToString();
        coin2Text.text = coin2Value.ToString();

        PlayerPrefs.SetInt("coin1Value", coin1Value);
        PlayerPrefs.SetInt("coin2Value", coin2Value);
    }
}