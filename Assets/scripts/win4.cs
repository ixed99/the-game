using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class win4: MonoBehaviour
{
    public float bruh;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "fly")
        {
            bruh = 1;
        }
    }

    private void Update()
    {
        if (bruh == 2)
        {
            SceneManager.LoadScene("u win screen");
        }
    }
}
