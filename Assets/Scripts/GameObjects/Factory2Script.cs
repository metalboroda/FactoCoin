using GameUI.ProgressBar;
using UnityEngine;

namespace GameObjects
{
    public class Factory2Script : MonoBehaviour
    {
        // Singleton
        public static Factory2Script Instance { get; private set; }

        // Vars
        public GameObject progressBar2;
        private bool _progressBar2IsActive;
        public int factory2Coins = 25;

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
            progressBar2.SetActive(false);
            _progressBar2IsActive = false;
        }

        private void Update()
        {
            AddCoin();
        }

        public void OnClickStartProgress()
        {
            if (_progressBar2IsActive == false)
            {
                progressBar2.SetActive(true);
                _progressBar2IsActive = true;
            }
            else
            {
                progressBar2.SetActive(false);
                _progressBar2IsActive = false;
                ProgressBar2Script.Instance.slider.value = 0;
            }
        }

        private void AddCoin()
        {
            if (ProgressBar2Script.Instance.slider.value >= 100)
            {
                CoinManagerScript.Instance.coin2Value += factory2Coins;
                ProgressBar2Script.Instance.slider.value = 0;
            }
        }
    }
}