using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource musicSource, sfxSource;
    public AudioClip musicClip;

    // Start is called before the first frame update
    void Start()
    {
        PlayBGMusic(); 
    }

    private void PlayBGMusic()
    {
        musicSource.clip = musicClip;
        musicSource.Play();
    }
}
