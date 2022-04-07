using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class SetVolume : MonoBehaviour
{
    public AudioMixer audioMixer;


    public void setVol(float SliderValue)
    {
        audioMixer.SetFloat("Volume", Mathf.Log10(SliderValue) * 20);
    }
}
//https://en.wikipedia.org/wiki/Decibel
//http://www.sengpielaudio.com/calculator-levelchange.htm
//"Typical question: Is 3 decibel more level twice as loud? Answer: No! Psychoacousticians tell us, that we must feel a level boost of 6 to 10 dB as twice as loud."
//teko eksperimentuoti nemazai kol mazdaug pavyko :D (GALVA DAUZT I SIENA NOREJOS)
//kiekviena karta gryztant i nustatymus slider value nusimusa ant max, bet garas islieka normalus