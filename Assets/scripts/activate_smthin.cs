using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_smthin : MonoBehaviour
{
    public GameObject the_thing;

    public GameObject thething_that_is_active;

    private void Start()
    {
        the_thing.active = false;
    }

    public void activate_that_thing()
    {
        the_thing.active = true;

    }


    public void disactivate()
    {
        thething_that_is_active.active = false;
    }
}