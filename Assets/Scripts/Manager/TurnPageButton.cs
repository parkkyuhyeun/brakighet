using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPageButton : MonoBehaviour
{
    [SerializeField] GameObject pageToChange;
    [SerializeField] GameObject currentPage;
    public void TurnPage()
    {
        pageToChange.SetActive(!pageToChange.gameObject.activeSelf);
        currentPage.SetActive(!currentPage.gameObject.activeSelf);
    }
}
