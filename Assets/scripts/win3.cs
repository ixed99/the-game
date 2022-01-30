using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win3 : MonoBehaviour
{
    public win4 win4;

    


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "fly")
        {


            win_();

        }
    }

    void win_()
    {
        if (win4.bruh == 1)
        {
            win4.bruh = 2;
        }
    }
}
