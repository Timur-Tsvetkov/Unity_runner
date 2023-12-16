using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float force = 65f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody player = GetComponent<Rigidbody>();
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))    
        {
            player.AddForce(force * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);

        }
        
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))    
        {
            player.AddForce(-force * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);

        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))    
        {
            player.AddForce(0f, 0f, force * Time.deltaTime, ForceMode.VelocityChange);

        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))    
        {
            player.AddForce(0f, 0f, -force * Time.deltaTime, ForceMode.VelocityChange);

        }
    }
}
