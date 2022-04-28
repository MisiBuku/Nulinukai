using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseScreen : MonoBehaviour
{
    //public AudioSource audioSource;
    //public SettingsMenu MySettingsMenu;
    //private float mVolume = SettingsMenu.mVolume;


    public static bool PausedGame = false;

    public GameObject PauseMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausedGame)
            {
                Continue();
            }
            else
            {
                Paused();
            }
        }
        //audioSource.volume = mVolume;
    }
    void Start()
    {
       // audioSource = GetComponent<AudioSource>();
       // Debug.Log(audioSource.volume);
    }

    public void Continue()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        PausedGame = false;
    }
    void Paused()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        PausedGame = true;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        PausedGame = false;
    }
    public void QuitGame(){
        Application.Quit();
    }
}