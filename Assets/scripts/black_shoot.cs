using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class black_shoot : MonoBehaviour
{
    public GameObject ink;

    public die die;

    public Transform point;

    public AudioSource putt_sfx;


    bool ready;

    private void Start()
    {
        ready = true;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && ready == true && die.thisone == false)
        {

            putt_sfx.Play();
            Instantiate(ink, transform.position, transform.rotation);

        }



    }
}
