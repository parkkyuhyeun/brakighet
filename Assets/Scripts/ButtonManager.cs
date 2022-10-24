using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject popup;
    [SerializeField] GameObject otherPopup;

    [SerializeField] GameObject objectToCreate;
    public void ChangePopupState()
    {
        if (otherPopup.gameObject.activeSelf == false)
        {
            popup.SetActive(!popup.gameObject.activeSelf);
        }
    }
    public void MakeObject()
    {
        float randomX = Random.Range(-9f, 9f);
        float randomY = Random.Range(-2f, 2f);
        Instantiate(objectToCreate, new Vector3(randomX,randomY,0), Quaternion.identity);
    }
}
