using UnityEngine;
using UnityEngine.SceneManagement;

public class SquareController : MonoBehaviour
{
    // This function is called when the square is clicked
    private void OnMouseDown()
    {
        // Load the next scene
        LoadNextScene();
    }

    private void LoadNextScene()
    {
        // Get the index of the current scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the next scene by incrementing the current scene index
        SceneManager.LoadScene(currentSceneIndex + 1);

        // If you want to loop back to the first scene when reaching the end, you can use the modulo operator
        // SceneManager.LoadScene((currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings);
    }
}
