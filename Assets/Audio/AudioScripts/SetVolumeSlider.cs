using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SetVolumeSlider : MonoBehaviour
{
    public AudioMixer audioMixer;
        public void setVol(float SliderValue)
    {
        audioMixer.SetFloat("Volume", Mathf.Log10(SliderValue) * 20);
    }
}