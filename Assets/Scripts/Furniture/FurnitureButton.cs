using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FurnitureButton : MonoBehaviour
{
    [SerializeField] GameObject objectToCreate;

    [SerializeField] TextMeshProUGUI furnitureText;

    public float level;
    private float increasingLevel = 1f;

    public float cost;
    private float increasingCost = 5000f;

    private float positionX;
    private float increasingPosition = 8f;

    private void Start()
    {
        furnitureText.text = $"level {level} Furniture\ncost:{cost}$";
        positionX = -10f;
    }
    public void MakeObject()
    {
        if (GameManager.instance.Amount >= cost)
        {
            Instantiate(objectToCreate, new Vector3(positionX, 1, 13), Quaternion.identity);
            GameManager.instance.Amount -= cost;
            cost += increasingCost;
            positionX += increasingPosition;
            level += increasingLevel;
        }
    }
    private void Update()
    {
        ChangeText(cost);
    }
    public void ChangeText(float cost)
    {
        furnitureText.text = $"level {level} Furniture\ncost:{cost}$";
    }
}
