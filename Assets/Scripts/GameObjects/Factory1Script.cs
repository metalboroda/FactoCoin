using GameUI.ProgressBar;
using UnityEngine;
using UnityEngine.UI;

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
        public Text _button1Text;
        public GameObject coin1;

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
                _button1Text.text = "STOP PROGRESS";
                progressBar1.SetActive(true);
                _progressBar1IsActive = true;
            }
            else
            {
                _button1Text.text = "START PROGRESS";
                progressBar1.SetActive(false);
                _progressBar1IsActive = false;
                ProgressBar1Script.Instance.slider.value = 0;
            }
        }

        private void AddCoin()
        {
            if (ProgressBar1Script.Instance.slider.value >= 100)
            {
                Instantiate(coin1);
                ProgressBar1Script.Instance.slider.value = 0;
            }
        }
    }
}