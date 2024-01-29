using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Minigame");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Minigame 1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Minigame 2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
