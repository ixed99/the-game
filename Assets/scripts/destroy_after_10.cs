using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_after_10 : MonoBehaviour
{
    public float life_time = 5f;

    private void Update()
    {
        if (gameObject.name != "black_ink")
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
