using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_to_the_next_one : MonoBehaviour
{
    

    private void Start()
    {
        Cursor.visible = true;

        Cursor.lockState =  CursorLockMode.None;
    }

    

    public void level2()
    {
        SceneManager.LoadScene("Level2");
    }


    public void Level1()
    {
        SceneManager.LoadScene("idk");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }
    public void Level5()
    {
        SceneManager.LoadScene("Level5");
    }


}
