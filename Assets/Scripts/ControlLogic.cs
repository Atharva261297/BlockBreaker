using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO;

public class ControlLogic : MonoBehaviour {

    private readonly float x_speed = 0.1F;

    //private BallControlLogic ball;

    // Use this for initialization
	void Start () {
        //ball = GameObject.FindObjectOfType<BallControlLogic>();
	}
	
	// Update is called once per frame
	void Update () {
        //print(transform.position.x);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(x_speed, 0, 0, Space.Self);
        
            if (transform.position.x > 5.5F)
            {
                transform.Translate(-x_speed, 0, 0, Space.Self);
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-x_speed, 0, 0, Space.Self);
            if (transform.position.x < -5.5F)
            {
                transform.Translate(x_speed, 0, 0, Space.Self);
            }
        }

        //Vector3 pos = new Vector3(ball.transform.position.x, transform.position.y, 0);
        //transform.position = pos;
	}
}