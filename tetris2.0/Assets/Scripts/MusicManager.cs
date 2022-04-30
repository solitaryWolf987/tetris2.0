using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    //public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;
    private float musicVolume = 0.8f;
    public Slider volumeSlider = null;
    public GameObject MusicObject;
    


    private void Start()
    {
        MusicObject = GameObject.FindWithTag("music");
        audioSource = MusicObject.GetComponent<AudioSource>();

        //musicVolume = PlayerPrefs.GetFloat("volume");
        audioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;

    }
   

    void Update()
    {
        audioSource.volume = musicVolume;
        //PlayerPrefs.SetFloat("volume", musicVolume);
    }
   
    public void SetVolume (float volume)
    {
        musicVolume = volume;
    }



}
