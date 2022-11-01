using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yakuza : MonoBehaviour
{
    public float money;
    private float waitTime = 5f;

    [SerializeField]
    private bool furnitureItSum = false;

    private Furniture furniture = null;

    private void Start()
    {
        StartCoroutine(MakeMoney());
    }
    private void FixedUpdate()
    {
        if (GameObject.FindObjectOfType<Furniture>() != null)
        {
            furnitureItSum = true;
        }
    }

    IEnumerator MakeMoney()
    {
        while (true)
        {
            if (gameObject.activeSelf)
            {
                yield return new WaitForSeconds(waitTime);
                if (furnitureItSum)
                {
                    GameManager.instance.Amount += money * 1.125f;
                }
                else
                {
                    GameManager.instance.Amount += money;
                }
            }
        }
    }
}
