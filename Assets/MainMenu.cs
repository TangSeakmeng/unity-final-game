using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
    }

    public void StartButton()
    {
        SceneManager.LoadScene("3DGameKitLite/Scenes/_TemplateScene");
    }
}
