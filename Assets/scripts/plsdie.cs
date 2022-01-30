using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class plsdie : MonoBehaviour
{



    public activate_win activate_Win;

    public die die;

    public GameObject GOTTIM_L;

    
    public activate_smthin activate_Smthin;



    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "ground")
        {
            gameObject.active = false;
        }
        else if (hit.gameObject.tag == "plane")
        {
            gameObject.active = false;
        }
        else if (hit.gameObject.tag == "Button")
        {
            activate_Smthin.activate_that_thing();
        
        }
        else if (hit.gameObject.tag == "fake_button")
        {
            StartCoroutine(GOTTIM());
        }
        else if (hit.gameObject.tag == "Button_win")
        {
            activate_Win.activate_that_thing();
        }







    }

    public float speed = 6f;
    public float gravity = 20f;

    public float jump = 8f;

    public CharacterController controller;

    Vector3 v3 = Vector3.zero;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisone = true;

        GOTTIM_L.active = false;
    }

    public bool thisone;


    private void Update()
    {
        


        if (controller.isGrounded && die.thisone == true  )
        {

            


            v3 = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

            v3 *= speed;

            v3 = transform.TransformDirection(v3);
        }

        v3.y -= gravity * Time.deltaTime;
        controller.Move(v3 * Time.deltaTime);
    }

    IEnumerator GOTTIM()
    {
        GOTTIM_L.active = true;

        yield return new WaitForSeconds(seconds: 1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
