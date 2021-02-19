using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int vel;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && rb.transform.position.x > -2)
        {
            rb.AddForce(transform.right * -vel);
        }

        else if (Input.GetKey(KeyCode.D) && rb.transform.position.x < 2)
        {
            rb.AddForce(transform.right * vel);
        }

        if (Input.GetKey(KeyCode.W) && rb.transform.position.y < 3)
        {
            rb.AddForce(transform.up * 2.5f * vel);
        }

        else if ( rb.position.y > -2)
        {
            rb.AddForce(transform.up * -2.5f * vel);
        }


    }
}
