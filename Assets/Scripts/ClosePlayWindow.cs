using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePlayWindow : MonoBehaviour
{
    public GameObject scrollingWindow;
    public GameObject menu;
    public void CloseWindow()
    {
        scrollingWindow.SetActive(false);
        menu.SetActive(true);
    }

    public void OpenWindow()
    {
        scrollingWindow.SetActive(true);
        menu.SetActive(false);
    }
}
