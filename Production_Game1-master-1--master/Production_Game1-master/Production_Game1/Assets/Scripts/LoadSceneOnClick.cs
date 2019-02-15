﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

    public void LoadByIndex(int sceneIndex)
    {

        SceneManager.LoadScene(sceneIndex);

        //SceneManager.LoadScene(SceneManager.GetActiveScene().sceneIndex);
                                                               
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
