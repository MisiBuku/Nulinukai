using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ScreenResolution : MonoBehaviour
{
   // public SettingsMenu MySettingsMenu;
   // private float mVolume = SettingsMenu.mVolume;
    public void small()
    {
        if (Screen.fullScreen == true)
        {
            Screen.SetResolution(800, 600, true);
        }
        else
        {
            Screen.SetResolution(800, 600, false);
        }
    }
    public void regular()
    {
        if (Screen.fullScreen == true)
        {
            Screen.SetResolution(1600, 900, true);
        }
        else
        {
            Screen.SetResolution(1600, 900, false);
        }
    }
    public void large()
    {
        if (Screen.fullScreen == true)
        {
            Screen.SetResolution(1920, 1080, true);
        }
        else
        {
            Screen.SetResolution(1920, 1080, false);
        }
    }
    public void fullscreen()
    {
        if (Screen.fullScreen == false)
        {
            Screen.fullScreen = true;
        }
        else
        {
            Screen.fullScreen = false;
        }
    }
    public void back()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            back();
        }
    }
}
