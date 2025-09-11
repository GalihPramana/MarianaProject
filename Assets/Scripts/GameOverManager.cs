using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void RestartGame()
    {
       
        SceneManager.LoadScene("Scene");
    }

    public void ExitGame()
    {

        //Application.Quit();
        //Debug.Log("Game Quit");
        SceneManager.LoadScene("MainMenu");
    }
}
