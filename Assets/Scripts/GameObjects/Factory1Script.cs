using GameUI.ProgressBar;
using UnityEngine;

namespace GameObjects
{
    public class Factory1Script : MonoBehaviour
    {
        // Singleton
        public static Factory1Script Instance { get; private set; }

        // Vars
        public GameObject progressBar1;
        private bool _progressBar1IsActive;
        public int factory1Coins = 10;

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
        }

        private void Start()
        {
            progressBar1.SetActive(false);
            _progressBar1IsActive = false;
        }

        private void Update()
        {
            AddCoin();
        }

        public void OnClickStartProgress()
        {
            if (_progressBar1IsActive == false)
            {
                progressBar1.SetActive(true);
                _progressBar1IsActive = true;
            }
            else
            {
                progressBar1.SetActive(false);
                _progressBar1IsActive = false;
                ProgressBar1Script.Instance.slider.value = 0;
            }
        }

        private void AddCoin()
        {
            if (ProgressBar1Script.Instance.slider.value >= 100)
            {
                CoinManagerScript.Instance.coin1Value += factory1Coins;
                ProgressBar1Script.Instance.slider.value = 0;
            }
        }
    }
}