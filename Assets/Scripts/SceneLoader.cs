using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(3);
    }
    public void LoseLevel()
    {
        SceneManager.LoadScene("LoseScene");
    }
    public void RestartLevel()
    {

        SceneManager.LoadScene("Hilly Homes");
            
    }

    public void RestartLevelAlps()
    {
        SceneManager.LoadScene("Freezing Alps");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("EndMenu");
    }

}
