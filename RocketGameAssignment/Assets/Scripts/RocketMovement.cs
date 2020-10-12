using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    float rotationLeftRight = 0;
    float rotationForwardBackward = 0;

    void Update()
    {
        // Exit Sample  
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }

        float rotation = 0.01f;
        //Change direction
        //space 
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 0.05f, 0);
        }
        
        //left 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotationLeftRight += rotation;
        }
        //right 
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotationLeftRight -= rotation;
        }

        //forward 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotationForwardBackward += rotation;
        }
        //backward
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rotationForwardBackward -= rotation;
        }



        //Set back to zero
        //left 
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rotationLeftRight = 0;
        }
        //right 
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rotationLeftRight = 0;
        }
        //forward 
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rotationForwardBackward = 0;
        }
        //backward
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rotationForwardBackward = 0;
        }


        //Where the magic happens
        transform.Rotate(rotationForwardBackward, 0, rotationLeftRight, Space.Self);
    }
}