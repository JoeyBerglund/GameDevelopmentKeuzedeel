using UnityEngine;
using UnityEngine.SceneManagement;  // For scene management

public class ReturnToHomeMenuTrigger : MonoBehaviour
{
    public string homeMenuSceneName = "HomeMenu";  // Name of the home menu scene

    private Collider objectCollider;  // Reference to the object's collider

    void Start()
    {
        // Get the collider attached to this GameObject
        objectCollider = GetComponent<Collider>();

        if (objectCollider == null)
        {
            Debug.LogError("No collider found on the object!");
        }
    }

    void Update()
    {
        // Check for collision with the player manually
        Collider[] hits = Physics.OverlapBox(
            objectCollider.bounds.center,
            objectCollider.bounds.extents / 2,
            Quaternion.identity
        );

        foreach (Collider hit in hits)
        {
            if (hit.CompareTag("Player"))
            {
                // Player has entered the trigger area
                Debug.Log("Player entered the return-to-home trigger!");
                SceneManager.LoadScene(homeMenuSceneName);
                break; // No need to check further once the player is found
            }
        }
    }
}
