using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YakuzaButton : MonoBehaviour
{
    [SerializeField] GameObject objectToCreate;

    [SerializeField] TextMeshProUGUI yakuzaText;

    private float cost = 10;
    private void Start()
    {
        yakuzaText.text = "Yakuza\ncost:10$";
    }
    public void MakeObject()
    {
        if (GameManager.instance.Amount >= cost)
        {
            float randomX = Random.Range(-9f, 9f);
            float randomY = Random.Range(-2f, 2f);
            float randomZ = Random.Range(0f, 10f);
            Instantiate(objectToCreate, new Vector3(randomX, randomY, randomZ), Quaternion.identity);
            GameManager.instance.Amount -= cost;
            cost += 5;
        }
    }
    private void Update()
    {
        ChangeText(cost);
    }
    public void ChangeText(float cost)
    {
        yakuzaText.text = $"Yakuza\ncost:{cost}$";
    }
}
