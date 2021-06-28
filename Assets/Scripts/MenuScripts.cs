using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart()
    {
        SceneManager.LoadScene("3DGamekitLite/Scenes/_TemplateScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
