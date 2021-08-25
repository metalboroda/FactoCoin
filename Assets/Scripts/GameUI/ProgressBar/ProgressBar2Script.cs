using UnityEngine;
using UnityEngine.UI;

namespace GameUI.ProgressBar
{
    public class ProgressBar2Script : MonoBehaviour
    {
        // Singleton
        public static ProgressBar2Script Instance { get; private set; }

        // Vars
        public Slider slider;

        public float fillSpeed = 0.5f;
        private float _targetProgress ;

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

            //
            slider = gameObject.GetComponent<Slider>();
        }

        private void Start()
        {
            IncrementProgress(100.0f);
        }

        private void Update()
        {
            if (slider.value < _targetProgress)
            {
                slider.value += fillSpeed * Time.deltaTime;
            }
        }

        public void IncrementProgress(float newProgress)
        {
            _targetProgress = slider.value + newProgress;
        }
    }
}