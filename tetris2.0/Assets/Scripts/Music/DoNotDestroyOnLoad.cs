using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroyOnLoad : MonoBehaviour
{
    void Awake()
    {
        GameObject[] musicObject = GameObject.FindGameObjectsWithTag("music");
        if (musicObject.Length > 1)
        {
            Debug.Log("Destroy on load: ");
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        //audioSource = GetComponent<AudioSource>();
        Debug.Log("Don't Destroy on load: ");
    }
}
