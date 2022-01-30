using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public float bruh;

    public float final;

    public AudioSource win_music;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "win")
        {
            bruh = 1;
        }
        if (hit.gameObject.tag == "win_final")
        {
           final = 1;
            Debug.Log("white touched the portal");
        }
    }

    private void Update()
    {
        if (bruh == 2)
        {
            wait_and_do_music();
        }
        if (final == 2)
        {
            win_win_ohoh();

           
        }
    }
    public void  wait_and_do_music()
    {

        SceneManager.LoadScene("u win screen");

    }

     public void  win_win_ohoh()
    {
        SceneManager.LoadScene("u_win_finish");
    }
}
       
    

