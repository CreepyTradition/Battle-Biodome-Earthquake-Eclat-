using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RockManager : MonoBehaviour
{
    public static int rockCount = 0; // Static variable to keep track of rock count
    public string nextSceneName; // Name of the next scene to load

    private void Start()
    {
        // Initialize rock count at the start of the scene
        rockCount = GameObject.FindGameObjectsWithTag("Rock").Length;
    }

    public static void RockDestroyed()
    {
        rockCount--; // Decrease rock count when a rock is destroyed

        if (SceneManager.GetActiveScene().name == "Hilly Homes")
        {
            if (rockCount <= 0)
            {
                SceneManager.LoadScene("WinScene");
            }
        } else if (SceneManager.GetActiveScene().name == "Freezing Alps")
        {
            if (rockCount <= 0)
            {
                SceneManager.LoadScene("WinSceneOne");
            }
        }
    }
}