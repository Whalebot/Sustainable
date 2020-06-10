using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public string tutorialSceneName;
    public string gameSceneName;
    public int sceneNumber;

    public void LoadTutorialScene()
    {
        SceneManager.LoadScene(tutorialSceneName);
    }

    public void LoadGameScene()
    {
        //SceneManager.LoadScene(gameSceneName);
        SceneManager.LoadScene(sceneNumber);

    }
}
