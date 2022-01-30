using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    
    public bool thisone;

  

    private void Start()
    
    {
        thisone = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("g"))
        {

            if (thisone == false)
            {

                thisone = true;
            }
            else if (thisone == true)
            {
         

              

                thisone = false;
            }
        }
    }
}
