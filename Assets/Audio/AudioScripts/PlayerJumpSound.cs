using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpSound : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip jumpFx;

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
            myFx.PlayOneShot(jumpFx);
    }
}
