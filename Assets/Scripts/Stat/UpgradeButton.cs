using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    public void IncreaseRateOfMoney(float amount)
    {
        UpgradeManager.Instance.MoneyRate += amount;
    }
}
