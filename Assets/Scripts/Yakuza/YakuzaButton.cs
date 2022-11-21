using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YakuzaButton : MonoBehaviour
{
    [SerializeField] GameObject objectToCreate;

    [SerializeField] TextMeshProUGUI yakuzaText;
    [SerializeField] private GameObject clickSound;

    public float level;
    public float cost;
    public float increasingValue;
    private void Start()
    {
        yakuzaText.text = $"Yakuza class {level}\ncost:{cost}$";
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
            cost += increasingValue;
        }
    }
    private void Update()
    {
        ChangeText(cost);
    }
    public void ChangeText(float cost)
    {
        yakuzaText.text = $"Yakuza class {level}\ncost:{cost}$";
    }
    public void PlaySound()
    {
        GameObject sound = GameObject.Instantiate(clickSound, transform);
        sound.GetComponent<AudioSource>().Play();
    }
}
