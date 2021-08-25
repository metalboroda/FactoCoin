using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Coin1ImageAnimation : MonoBehaviour
{
    // Singleton
    public static Coin1ImageAnimation Instance { get; private set; }

    public GameObject coin1Image;

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
        coin1Image.transform.DOShakeScale(1, 0.05f, 10, 90, true);
    }
}