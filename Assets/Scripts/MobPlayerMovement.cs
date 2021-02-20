using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobPlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int vel;
    public float maxHeight;
    // Start is called before the first frame update
    private void Start()
    {
        Globals.health = 10;
        Globals.enemyHealth = 10;
    }
    // Update is called once per frame
    void Update()
    {


        rb.AddForce(new Vector2 (Input.acceleration.x, 0 )* vel);

        if (Input.GetMouseButton(0) && rb.transform.position.y < maxHeight)
        {
            rb.AddForce(transform.up * 2.5f * vel);
        }

        else if (rb.position.y > -2)
        {
            rb.AddForce(transform.up * -2.5f * vel);
        }


    }
}
