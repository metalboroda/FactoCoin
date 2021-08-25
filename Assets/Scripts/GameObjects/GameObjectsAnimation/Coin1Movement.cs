using DG.Tweening;
using UnityEngine;

namespace GameObjects.GameObjectsAnimation
{
    public class Coin1Movement : MonoBehaviour
    {
        private Vector3 _startPoint;
        private Vector3 _endPoint;

        // Start coordinates
        public float startPointX;
        public float startPointY;
        public float startPointZ;

        // End coordinates
        public float endPointX;
        public float endPointY;
        public float endPointZ;

        [SerializeField] float duration;

        public float _destroyTime;

        void Start()
        {
            _startPoint = new Vector3(startPointX, startPointY, startPointZ);
            _endPoint = new Vector3(endPointX, endPointY, endPointZ);
            Vector3[] pathway = {_startPoint, _endPoint};
            transform.DOPath(pathway, duration, PathType.CatmullRom)
                .OnStepComplete(() => CoinManagerScript.Instance.coin1Value += Factory1Script.Instance.factory1Coins)
                .OnComplete(Coin1ImageAnimation.Instance.ShakeMethod);
        }

        private void Update()
        {
            Destroy(gameObject, _destroyTime);
        }
    }
}