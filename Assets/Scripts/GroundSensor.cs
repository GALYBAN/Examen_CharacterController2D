using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{

    public static bool isGrounded;

    [SerializeField] private LayerMask layer;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 3)
        {
            isGrounded = true;
           MageController.anim.SetBool("isJumping", false);
        }

    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 3)
        {
            isGrounded = true;
           MageController.anim.SetBool("isJumping", false);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 3)
        {
            isGrounded = false;
           MageController.anim.SetBool("isJumping", true);
        }
    }

}
