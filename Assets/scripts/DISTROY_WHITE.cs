using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DISTROY_WHITE : MonoBehaviour
{
    public float life_time = 5f;

    private void Update()
    {
        if (gameObject.name != "white_ink")
        {
            if (life_time != 0)
            {
                life_time -= Time.deltaTime;

                if (life_time <= 0)
                {
                    Destroy(gameObject);
                }

            }
        }





    }

}
