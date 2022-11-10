using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject popup;

    [SerializeField] Button pressedButton;
    [SerializeField] Button[] anotherButton;
    public void OpenPopup()
    {
        pressedButton.interactable = false;
        foreach(Button b in anotherButton)
        {
            b.interactable = false;
        }

        popup.SetActive(!popup.gameObject.activeSelf);
    }
    public void ClosePopup()
    {
        if (popup.gameObject.activeSelf == true)
        {
            popup.SetActive(false);
        }
        pressedButton.interactable = true;
        foreach (Button b in anotherButton)
        {
            b.interactable = true;
        }
    }

    public void MoveScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
}
