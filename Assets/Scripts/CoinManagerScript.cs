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
        // Singleton
        if (Instance == null)
        {
            Instance = this;
            // DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        //
    }

    private void Update()
    {
        coin1Text.text = coin1Value.ToString();
        coin2Text.text = coin2Value.ToString();
    }
}