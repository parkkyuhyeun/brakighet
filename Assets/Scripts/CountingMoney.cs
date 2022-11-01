using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CountingMoney : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI amountText;

    public float percent;

    private void Start()
    {
        amountText.text = "0 $";
        GameManager.instance.Amount = 10;
        percent = 1f;
    }
    private void Update()
    {
        ChangeText(GameManager.instance.Amount);
    }
    public void ChangeText(float amount)
    {
        amountText.text = amount.ToString("F2") + " $";
    }
}
