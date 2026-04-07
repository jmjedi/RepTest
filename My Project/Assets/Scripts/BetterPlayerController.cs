using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterPlayerController : MonoBehaviour
{
    public float jumpForce = 150.0f;
    public float smoothness = 0.1f;
    private float XSpd = 0f;
    private float YSpd = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //X Movement
        if (Input.GetKey(KeyCode.D))
        {
            XSpd = 0.035f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            XSpd = -0.035f;
        }

        //Y Movement
        if (Input.GetKey(KeyCode.W))
        {
            YSpd = 0.035f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            YSpd = -0.035f;
        }
        
        //Jump Power
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, jumpForce * smoothness, 0.0f));
        }

        //acceleration handler

        //X Speed

        transform.position = transform.position + (transform.right * (XSpd));
        XSpd *= smoothness;

        //Y Speed
        transform.position = transform.position + (transform.forward * (YSpd));
        YSpd *= smoothness;


    }
}
