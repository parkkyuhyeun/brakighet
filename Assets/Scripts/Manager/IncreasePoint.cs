using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IncreasePoint : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointText;
    void Start()
    {
        pointText.text = "0";
        GameManager.instance.UpgradePoint = 0;
    }

    void Update()
    {
        ChangeText(GameManager.instance.UpgradePoint);   
    }
    public void ChangeText(int point)
    {
        pointText.text = "Point : " + point.ToString();
    }
}
