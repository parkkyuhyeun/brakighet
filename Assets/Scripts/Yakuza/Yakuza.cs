using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yakuza : MonoBehaviour
{
    public float money;
    public float combat;
    public int point;

    private float waitTime = 5f;

    [SerializeField]
    private bool furnitureItSum = false;

    private void Start()
    {
        StartCoroutine(MakeMoney());
        StartCoroutine(IncreaseCombat());
        StartCoroutine(GetPoint());
    }

    IEnumerator MakeMoney()
    {
        while (true)
        {
            if (gameObject.activeSelf)
            {
                yield return new WaitForSeconds(waitTime);
                Furniture[] furniture = GameObject.FindObjectsOfType<Furniture>();
                if (furniture.Length > 0)
                {
                    furnitureItSum = true;
                }
                if (furnitureItSum)
                {
                    money *= 1 + (0.125f * furniture.Length);
                    money += UpgradeManager.Instance.MoneyRate;
                    GameManager.instance.Amount += money;
                }
                else
                {
                    money += UpgradeManager.Instance.MoneyRate;
                    GameManager.instance.Amount += money;
                }
            }
        }
    }
    IEnumerator IncreaseCombat()
    {
        if (gameObject.activeSelf)
        {
            combat += UpgradeManager.Instance.CombatRate;
            GameManager.instance.Combat += combat;
            yield return 0;
        }
    }
    IEnumerator GetPoint()
    {
        while (true)
        {
            if (gameObject.activeSelf)
            {
                yield return new WaitForSeconds(300);
                GameManager.instance.UpgradePoint += point;
            }
        }
    }
}
