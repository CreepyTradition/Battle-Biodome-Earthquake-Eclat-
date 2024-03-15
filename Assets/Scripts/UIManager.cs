using UnityEngine;
using UnityEngine.UI; // Add this line to access Unity's UI namespace
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text rocksCountText;

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Hilly Homes")
        {
            rocksCountText.text = "Rocks Left: " + RockManager.rockCount;
        }
        else if (SceneManager.GetActiveScene().name == "Freezing Alps") {

            rocksCountText.text = "Rocks Left: " + RockManager.rockCount;
        }
    }
}