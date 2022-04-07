using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    void Start()
    {

    }
    public void ResolutionMenu()
    {
        SceneManager.LoadScene("Resolution");
    }

    public void Back()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void Update()
   {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Back();
        }
    }
}
