using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_win : MonoBehaviour
{
    public GameObject the_thing;



    private void Start()
    {
        the_thing.active = false;
    }

    public void activate_that_thing()
    {
        the_thing.active = true;
    }
}
