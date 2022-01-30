using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class die_loose : MonoBehaviour
{
    public GameObject white;
    public GameObject black;

  

    public GameObject L;

    private void Start()
    {
        L.active = false;

       
    }

    private void FixedUpdate()
    {
        if (black.active == false || white.active == false || black.active == false && white.active == false)
        {
            L.active = true;

            StartCoroutine(wait());

            

        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(seconds: 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


