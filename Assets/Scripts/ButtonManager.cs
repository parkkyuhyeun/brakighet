using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject popup;
    [SerializeField] GameObject otherPopup;

    [SerializeField] Button pressedButton;
    [SerializeField] Button anotherButton;
    public void OpenPopup()
    {
        pressedButton.interactable = false;
        anotherButton.interactable = false;

        if (otherPopup.gameObject.activeSelf == false)
        {
            popup.SetActive(!popup.gameObject.activeSelf);
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
