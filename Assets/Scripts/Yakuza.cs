using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yakuza : MonoBehaviour
{
    private float money = 20;
    private float waitTime = 2f;

    private void Start()
    {
        StartCoroutine(MakeMoney());
    }
    IEnumerator MakeMoney()
    {
        while (true)
        {
            if (gameObject.activeSelf)
            {
                yield return new WaitForSeconds(waitTime);
                GameManager.instance.Amount += money;
            }
        }
    }
}
