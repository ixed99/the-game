using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win2: MonoBehaviour
{
    public win win;


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "win")
        {
           
            win_();

           
        }
        if (hit.gameObject.tag == "win_final")
        {
            Debug.Log("black touched it u wieardo ");
            win_final();
           
        }
    }

    public void win_()
    {
        if (win.bruh == 1)
        {
            win.bruh = 2;
        }
    }
    public void win_final()
    {
        if (win.final == 1)
        {
            
            win.final = 2;
        }
    }
}
