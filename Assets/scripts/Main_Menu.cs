using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("idk");
    }

    public void quit()
    {
       Application.Quit();
    }

    public void level_selector()
    {
        SceneManager.LoadScene("Level selector");
    }

    public void help()
    {
        SceneManager.LoadScene("help");
    }

    public void about_us()
    {
        SceneManager.LoadScene("about us");
    }
}
