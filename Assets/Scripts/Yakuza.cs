using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yakuza : MonoBehaviour
{
    public float money;
    private float waitTime = 5f;

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
