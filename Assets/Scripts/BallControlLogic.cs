using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControlLogic : MonoBehaviour {


    //private ControlLogic ballPad = GameObject.FindObjectOfType<ControlLogic>();
    Vector3 vectorDiff;
    private ControlLogic ballPad;
    
    bool gameStarted = false;

	// Use this for initialization
	void Start () {
        //vectorDiff = transform.position - ballPad.transform.position;
        ballPad = GameObject.FindObjectOfType<ControlLogic>();
        
        vectorDiff.y = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        if (!gameStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameStarted = true;
                GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-2.5F,2.5F),6F);
            }
            else
            {
                vectorDiff.x = ballPad.transform.position.x;
                vectorDiff.z = 0F;
                this.transform.position = vectorDiff;
            }
        }
        
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Rigidbody2D>().velocity += new Vector2(Random.Range(-0.5F, 0.5F), Random.Range(-0.5F, 0.5F));
    }
}
