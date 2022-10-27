using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CountingMoney : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI amountText;

    private float amount = 0;
    public float Amount { get => amount; set => amount = value; }
    private void Start()
    {
        amountText.text = "0 $";
        Amount = 5;
    }
    private void Update()
    {
        ChangeText(Amount);
    }
    public void ChangeText(float amount)
    {
        amountText.text = (int)amount + " $";
    }
}
