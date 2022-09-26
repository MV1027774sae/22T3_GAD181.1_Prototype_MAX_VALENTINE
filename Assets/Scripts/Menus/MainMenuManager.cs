using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject controlsPanel;

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
    }

    public void HideMainMenu()
    {
        mainMenuPanel.SetActive(false);
    }

    public void ShowControls()
    {
        controlsPanel.SetActive(true);
    }

    public void HideControls()
    {
        controlsPanel.SetActive(false);
    }

    public void LoadScene(int sceneIndex)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);

    }
}
