using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject popup;
    [SerializeField] GameObject otherPopup;

    [SerializeField] Button pressedButton;
    [SerializeField] Button anotherButton;

    [SerializeField] GameObject objectToCreate;
    public void OpenPopup()
    {
        pressedButton.interactable = false;
        anotherButton.interactable = false;

        if (otherPopup.gameObject.activeSelf == false)
        {
            popup.SetActive(!popup.gameObject.activeSelf);
        }
    }
    public void MakeObject()
    {
        if(GameManager.instance.Amount >= 10)
        {
            float randomX = Random.Range(-9f, 9f);
            float randomY = Random.Range(-2f, 2f);
            Instantiate(objectToCreate, new Vector3(randomX,randomY,0), Quaternion.identity);
            GameManager.instance.Amount -= 10;
        }
    }
    public void ClosePopup()
    {
        if (popup.gameObject.activeSelf == true)
        {
            popup.SetActive(false);
        }
        pressedButton.interactable = true;
        anotherButton.interactable = true;
    }
}
