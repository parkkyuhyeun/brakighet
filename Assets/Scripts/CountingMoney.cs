using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CountingMoney : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI amountText;


    private void Start()
    {
        amountText.text = "0 $";
        GameManager.instance.Amount = 5;
    }
    private void Update()
    {
        ChangeText(GameManager.instance.Amount);
    }
    public void ChangeText(float amount)
    {
        amountText.text = (int)amount + " $";
    }
}
