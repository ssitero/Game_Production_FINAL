using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{

    public static bool GameIsWon = false;
    public GameObject WinMenuUI;


    // Update is called once per frame
    void Update()
    {
        if (GameIsWon == true){
            Win();
        }
       
    }


    public void Win(){

        WinMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsWon = true;
}


    public void QuitGame()
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1f;
        WinMenu.GameIsWon = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());

    }

}