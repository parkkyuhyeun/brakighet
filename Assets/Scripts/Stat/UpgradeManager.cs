using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    private static UpgradeManager instance;
    public static UpgradeManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<UpgradeManager>();

            return instance;
        }
    }

    [SerializeField] private float moneyRate = 0.0f;

    public float MoneyRate
    {
        get => moneyRate;
        set => moneyRate = value;
    }

}
