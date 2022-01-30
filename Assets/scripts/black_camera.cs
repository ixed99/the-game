using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class black_camera : MonoBehaviour
{
    float MouseX;

    public die die;

    public float sensetivity = 100f;





    private void Start()
    {
        Cursor.visible = false;

        Cursor.lockState = CursorLockMode.Locked;
    }




    private void Update()
    {

        if (die.thisone == false)

            MouseX = Input.GetAxis("Mouse X") * sensetivity * Time.deltaTime ;

        transform.Rotate(Vector3.up * MouseX);
    }
}
