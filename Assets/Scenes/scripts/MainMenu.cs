using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;
    //public SettingsMenu MySettingsMenu;
    //private float mVolume = MySettingsMenu.mVolume;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Update()
    {
        //audioSource.volume = mVolume;
    }
    public void StartGame ()
    {
        SceneManager.LoadScene("Level1Scene");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

}
