using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * A class to set the timeScale to 1 when function is called.
 */

public class SetTime : MonoBehaviour
{
   public void SetTimeOn()
    {
        Time.timeScale = 1f;
    }
}
