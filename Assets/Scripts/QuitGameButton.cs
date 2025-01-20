using UnityEngine;

public class QuitGameButton : MonoBehaviour
{
    // Public method to quit the game
    public void QuitGame()
    {
        Debug.Log("Quit Game button clicked!");

#if UNITY_EDITOR
        // If running in the Unity Editor, stop play mode
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // If the game is built, quit the application
        Application.Quit();
#endif
    }
}
