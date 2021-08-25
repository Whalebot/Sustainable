using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public int sceneNumber;

    public void LoadGameScene()
    {
        //SceneManager.LoadScene(gameSceneName);
        SceneManager.LoadScene(sceneNumber);

    }
}
