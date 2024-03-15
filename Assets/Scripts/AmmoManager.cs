using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour
{
    public int maxAmmo = 5; // Maximum ammo count
    private int currentAmmo; // Current ammo count
    public Text ammoText; // Reference to the UI Text for displaying ammo count

    void Start()
    {
        currentAmmo = maxAmmo;
        UpdateAmmoText();
    }

    public void FireCannonball()
    {
        currentAmmo--;
        UpdateAmmoText();
        if (SceneManager.GetActiveScene().name == "Hilly Homes")
        {
            if (currentAmmo <= -1)
            {
                // Load the lose scene when ammo runs out
                SceneManager.LoadScene("LoseScene");
            }
        }
        if (SceneManager.GetActiveScene().name == "Freezing Alps")
        {
            if (currentAmmo <= -1)
            {
                // Load the lose scene when ammo runs out
                SceneManager.LoadScene("LoseSceneOne");
            }
        }
    }

    void UpdateAmmoText()
    {
        ammoText.text = "Ammo: " + currentAmmo;
    }
}
