using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string scene;
    public Color loadToColor = Color.black;
    public void StartGame()
    {
        Initiate.Fade(scene, loadToColor, 1.0f);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("WE QUIT THE MENU");
        Application.Quit();
    }
}
