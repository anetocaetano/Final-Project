using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManager : MonoBehaviour {
   
    public void NewGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void BackBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void SettingsBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
