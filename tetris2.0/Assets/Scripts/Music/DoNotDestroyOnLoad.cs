using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Class to keep music running thorughout all the scenes,
 * without restarting or playing over each other.
 */

public class DoNotDestroyOnLoad : MonoBehaviour
{
    void Awake()
    {
        GameObject[] musicObject = GameObject.FindGameObjectsWithTag("music");
        if (musicObject.Length > 1)
        {
            //Debug.Log("Destroy on load: ");
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        //Debug.Log("Don't Destroy on load: ");
    }
}
