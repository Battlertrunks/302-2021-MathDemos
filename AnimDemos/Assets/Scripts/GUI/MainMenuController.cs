using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuController : MonoBehaviour
{
    EventSystem events;

    void Start()
    {
        events = GetComponentInChildren<EventSystem>();
    }

    
    void Update()
    {
        if (events == null)
            return;

        if (events.currentSelectedGameObject == null)
        {
            if (events.firstSelectedGameObject != null)
                events.SetSelectedGameObject(events.firstSelectedGameObject);
        }
    }

    public void BttnPlay()
    {
        print("play");
        SceneManager.LoadScene("Week1");
    }

    public void BttnAbout()
    {
        print("About");
    }

    public void BttnQuit()
    {
        print("Quit");
        Application.Quit();
    }
}
