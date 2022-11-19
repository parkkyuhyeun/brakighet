using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurnPageButton : MonoBehaviour
{
    [SerializeField] GameObject pageToChange;
    [SerializeField] GameObject currentPage;
    public void TurnPage()
    {
        pageToChange.SetActive(!pageToChange.gameObject.activeSelf);
        currentPage.SetActive(!currentPage.gameObject.activeSelf);
    }
    public void TurnScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
