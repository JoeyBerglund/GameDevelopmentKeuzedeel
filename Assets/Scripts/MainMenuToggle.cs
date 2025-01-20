using UnityEngine;

public class MainMenuToggle : MonoBehaviour
{
    public GameObject mainMenuPanel;  // Reference to the main menu panel

    private bool isMenuActive = false; // Track whether the menu is currently visible

    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMainMenu();
        }
    }

    void ToggleMainMenu()
    {
        // Toggle the visibility of the main menu panel
        isMenuActive = !isMenuActive;
        mainMenuPanel.SetActive(isMenuActive);

        // Optionally pause the game when the menu is opened
        if (isMenuActive)
        {
            Time.timeScale = 0f; // Pauses the game
        }
        else
        {
            Time.timeScale = 1f; // Resumes the game
        }
    }
}
