using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScreenResolutions : MonoBehaviour {
    
    public static void ScreenResolution1()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    public void ScreenResolution2()
    {
        Screen.SetResolution(1280, 720, true, 60);
    }

    public void ScreenResolution3()
    {
        Screen.SetResolution(1920, 1080, true, 60);
    }
}
