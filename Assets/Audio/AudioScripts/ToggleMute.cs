using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ToggleMute : MonoBehaviour
{  

    public void muteVolume(bool muted)
    {
        if(muted)
        {
            AudioListener.volume=0;
        }
        else
        {
            AudioListener.volume=1;
        }
    }

}
