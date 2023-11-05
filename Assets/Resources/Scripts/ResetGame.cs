using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
   
 public void ReloadScene()
    {
        GravityPocket.ballsInPocket = 0;
        // Get the name of the current scene.
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Reload the current scene.
        SceneManager.LoadScene(currentSceneName);
    }
}
