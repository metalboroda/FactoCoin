using DG.Tweening;
using GameObjects;
using UnityEngine;

public class Coin2Movement : MonoBehaviour
{
    private Vector3 startPoint;
    private Vector3 endPoint;

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
        startPoint = new Vector3(startPointX, startPointY, startPointZ);
        endPoint = new Vector3(endPointX, endPointY, endPointZ);
        Vector3[] pathway = {startPoint, endPoint};
        transform.DOPath(pathway, duration, PathType.CatmullRom)
            .OnStepComplete(() => CoinManagerScript.Instance.coin2Value += Factory2Script.Instance.factory2Coins)
            .OnComplete(Coin2ImageAnimation.Instance.ShakeMethod);
    }

    private void Update()
    {
        Destroy(gameObject, _destroyTime);
    }
}