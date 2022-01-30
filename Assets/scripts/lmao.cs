using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lmao : MonoBehaviour
{
    public GameObject ink;

    public AudioSource putt_sfx;

    public die die;

    public Transform point;

    bool ready;

    private void Start()
    {
        ready = true;
    }

    private void Update()
    {
       if (Input.GetMouseButton(0) && ready == true && die.thisone == true)
        {
            putt_sfx.Play();

            Instantiate(ink, transform.position , transform.rotation);
           
        }

        

    }

    
}
