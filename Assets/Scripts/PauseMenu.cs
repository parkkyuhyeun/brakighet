using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!GameManager.isPause)
            {
                CallMenu();
            }
            else
            {
                CallMenu();
            }
        }
    }
    private void CallMenu()
    {
        GameManager.isPause = true;
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    private void CloseMenu()
    {
        GameManager.isPause = false;
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void ClickLoad()
    {

    }
    public void ClickMainMenu()
    {

    }
    public void ClickExit()
    {
        Application.Quit();
    }
}
