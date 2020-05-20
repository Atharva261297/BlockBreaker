using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	public void SceneChange(string scene)
    {
        string sceneName = scene + "Scene";
        SceneManager.LoadScene(sceneName);
        Bricks.brickCount = 0;
    }

    public void LoadNextScene()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(activeScene.buildIndex + 1);
        Bricks.brickCount = 0;
    }

    public void QuitApplication()
    {
        Application.Quit();
    }

    public void Won()
    {
        if (Bricks.brickCount == 0)
        {
            LoadNextScene();
        }
    }
}
