using GameUI.ProgressBar;
using GameUI.UIAnimations;
using UnityEngine;
using UnityEngine.UI;

namespace GameObjects
{
    public class Factory2Script : MonoBehaviour
    {
        // Singleton
        public static Factory2Script Instance { get; private set; }

        // Vars
        public GameObject progressBar2;

        public int factory2Coins = 25;
        public GameObject factory2StartButton;
        public Text _button2Text;
        public GameObject coin2;

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
            factory2StartButton.SetActive(true);
            progressBar2.SetActive(false);
        }

        private void Update()
        {
            ButtonActivation();
            AddCoin();
        }

        private void ButtonActivation()
        {
            if (CoinManagerScript.Instance.coin1Value >= 10)
            {
            }
            else
            {
                _button2Text.text = "START PROGRESS";
                if (ProgressBar2Script.Instance.slider.value >= 100f)
                {
                    progressBar2.SetActive(false);
                }
            }
        }

        public void OnClickStartProgress()
        {
            if (CoinManagerScript.Instance.coin1Value >= 10)
            {
                _button2Text.text = "STOP PROGRESS";
                progressBar2.SetActive(true);
                CoinManagerScript.Instance.coin1Value -= 10;
            }
            else
            {
                WarningPanelAnimation.Instance.WarningTweenMethod();
                _button2Text.text = "START PROGRESS";
                progressBar2.SetActive(false);
                ProgressBar2Script.Instance.slider.value = 0;
            }
        }

        private void AddCoin()
        {
            if (ProgressBar2Script.Instance.slider.value >= 100)
            {
                Instantiate(coin2);
                ProgressBar2Script.Instance.slider.value = 0;
            }
        }
    }
}