using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {

    private SceneChanger sceneChanger;

    // Use this for initialization
    public static int brickCount = 0;
	void Start () {
        brickCount++;
        print(brickCount);
        sceneChanger = GameObject.FindObjectOfType<SceneChanger>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        brickCount--;
        print(brickCount);
        Destroy(gameObject);
        sceneChanger.Won();
    }
}
