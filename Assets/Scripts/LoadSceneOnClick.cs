using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{
    // The name of the scene to load
    [SerializeField] private string sceneToLoad;

    // Method to load the scene
    public void LoadScene()
    {
        Debug.Log("Button clicked! Attempting to load scene: " + sceneToLoad);

        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("Scene name is not set or is empty!");
        }
    }
}
