using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    public GameObject settingsWindow;

    public void OpenWindow()
    {
        settingsWindow.SetActive(true);
    }
    public void CloseWindow()
    {
        settingsWindow.SetActive(false);
    }
}
