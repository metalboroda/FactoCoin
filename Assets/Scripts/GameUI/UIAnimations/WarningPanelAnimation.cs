using System;
using DG.Tweening;
using UnityEngine;

namespace GameUI.UIAnimations
{
    public class WarningPanelAnimation : MonoBehaviour
    {
        // Singleton
        public static WarningPanelAnimation Instance { get; private set; }

        [SerializeField] float startPosX;
        [SerializeField] float durationIn;
        [SerializeField] float endPosX;
        [SerializeField] float durationOut;

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

        public void WarningTweenMethod()
        {
            var Seq = DOTween.Sequence();
            Seq.Append(gameObject.transform.DOLocalMoveX(endPosX, durationIn));
            Seq.Append(gameObject.transform.DOLocalMoveX(startPosX, durationOut));
        }
    }
}