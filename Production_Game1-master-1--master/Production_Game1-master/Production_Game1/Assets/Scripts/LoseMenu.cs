using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseMenu : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;
    public static bool GameIsLost = false;
    public GameObject LoseMenuUI;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }


    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (GameIsLost == true)
        {
            Lose();
        }
        if (currentTime <= 0)
        {

            LoseMenu.GameIsLost = true;
            currentTime = 0;

        }

    }


    public void Lose()
    {

        LoseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsLost = true;
    }


    public void QuitGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1f;
        LoseMenu.GameIsLost = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());

    }

}