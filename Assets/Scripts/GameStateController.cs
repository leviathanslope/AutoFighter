using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStateController : MonoBehaviour
{
    [SerializeField] GameObject _MenuPanel;
    [SerializeField] GameObject _SettingsPanel;
    void Update()
    {
        //brings up pop up menu
        if ((Input.GetKeyDown(KeyCode.Escape)) && (_MenuPanel.activeSelf == false))
        {
            PopUpMenu();
        }
        else if ((Input.GetKeyDown(KeyCode.Escape)) && (_MenuPanel.activeSelf == true))
        {
            Resume();
        }
    }
    public void ExitLevel()
    {
        //load main menu scene
        SceneManager.LoadScene("MainMenu");
    }
    public void PopUpMenu()
    {
        //makes pop up menu visible
        _MenuPanel.SetActive(true);
    }
    public void Resume()
    {
        //makes pop up menu disappear
        _MenuPanel.SetActive(false);
        //if settings menu is up it also closes
        _SettingsPanel.SetActive(false);
    }
}
