using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI usingPointText;

    [SerializeField] GameObject clickSound;

    public int pointConsumption;
    public int pointConsumption2;
    public int increasingPoint;
    public int increasingPoint2;
    public void IncreaseRateOfMoney(float amount)
    {
        if(GameManager.instance.UpgradePoint >= pointConsumption)
        {
            UpgradeManager.Instance.MoneyRate += amount;
            GameManager.instance.UpgradePoint -= pointConsumption;
            pointConsumption += increasingPoint;
            ChangeText(pointConsumption);
        }
    }
    public void IncreaseCombat(float power)
    {
        if (GameManager.instance.UpgradePoint >= pointConsumption2)
        {
            UpgradeManager.Instance.CombatRate += power;
            GameManager.instance.UpgradePoint -= pointConsumption2;
            pointConsumption2 += increasingPoint2;
            ChangeText(pointConsumption2);
        }
    }
    public void ChangeText(int point)
    {
        usingPointText.text = $"-{point} point";
    }
    public void PlaySound()
    {
        GameObject sound = Instantiate(clickSound, transform);
        sound.GetComponent<AudioSource>().Play();
    }
}
