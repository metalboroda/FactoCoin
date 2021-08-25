using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Coin2ImageAnimation : MonoBehaviour
{
    // Singleton
    public static Coin2ImageAnimation Instance { get; private set; }

    public GameObject coin2Image;

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

    public void ShakeMethod()
    {
        coin2Image.transform.DOShakeScale(1, 0.05f, 10, 90, true);
    }
}
