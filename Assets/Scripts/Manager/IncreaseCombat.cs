using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IncreaseCombat : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI combatText;
    void Start()
    {
        combatText.text = "0";
        GameManager.instance.Combat = 0;
    }

    void Update()
    {
        ChangeText(GameManager.instance.Combat);
    }
    public void ChangeText(float combat)
    {
        combatText.text = combat.ToString();
    }
}
