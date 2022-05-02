using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Class that Finds and allows the audio source to be played.
 * Allows for the volume slider to update the volume, and the volume be saved.
 */

public class MusicManager : MonoBehaviour
{
    
    private AudioSource audioSource;
    private float musicVolume = 1f;
    public Slider volumeSlider;
    public GameObject MusicObject;
    


    private void Start()
    {
        //Get Object Tag
        MusicObject = GameObject.FindWithTag("music");
        audioSource = MusicObject.GetComponent<AudioSource>();

        //Set volume
        musicVolume = PlayerPrefs.GetFloat("volume");
        audioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;
        
    }

    void Update()
    {
        audioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);
    }
   
    //Slider changes, the musicVolume variable is updated.
    public void updateVolume (float volume)
    {
        musicVolume = volume;
    }

    public void MusicRest()
    {
        PlayerPrefs.DeleteKey("volume");
        audioSource.volume = 1f;
        volumeSlider.value = 1f;
    }

}
