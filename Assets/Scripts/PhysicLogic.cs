using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicLogic : MonoBehaviour {

    private SceneChanger sceneChanger;

    //For Bottom Collider
    public void OnTriggerEnter2D(Collider2D collision)
    {
        sceneChanger.SceneChange("Lose");
    }

    public void Start()
    {
        sceneChanger = GameObject.FindObjectOfType<SceneChanger>();
    }
}
