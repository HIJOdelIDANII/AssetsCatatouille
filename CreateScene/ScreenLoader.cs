using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Load a scene by its name
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Exit the application
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Closed!"); // This will only show in the editor
    }
}
