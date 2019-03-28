using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("APP QUIT");
        Application.Quit();
    }

    public void Restart()
    {
        Debug.Log("APP RESTART");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
