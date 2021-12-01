using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;



public class MenuController : MonoBehaviour
{
    public Transform Title;
    public GameObject[] buttons;
    private List<GameData> userGames;
    private GameObject last;

    private Vector3 titlePosition;
    void Awake()
    {
        userGames = SaveSystem.getAllGames();
    }

    // Start is called before the first frame update
    void Start()
    {
        titlePosition = Title.position;
        buttons[0].SetActive(true);
 
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }


    public void play()
    {
        titlePosition = Title.position;
        foreach (GameObject b in buttons)
        {
            if (b.name == "Load Buttons")
                b.SetActive(true);
            else
                b.SetActive(false);
        }
    }
    public void settings()
    {
        Title.position = new Vector3(Title.position.x, Title.position.y + 60, Title.position.z);
        foreach (GameObject b in buttons)
        {
            if (b.name == "Settings Buttons")
                b.SetActive(true);
            else
                b.SetActive(false);
        }
    }
    public void credits()
    {
        Title.gameObject.SetActive(false);
        foreach (GameObject b in buttons)
        {
            if (b.name == "Credits")
                b.SetActive(true);
            else
                b.SetActive(false);
        }
    }

    public void Back()
    {
        Title.gameObject.SetActive(true);
        Title.position = titlePosition;
        foreach (GameObject b in buttons)
        {
            if (b.name == "Menu Buttons")
                b.SetActive(true);
            else
                b.SetActive(false);
        }
    }

    public void Resume()
    {
        GameData last = lastPlayedGame();
    }
    public void exit()
    {
        Application.Quit();
    }

    private GameData lastPlayedGame()
    {
        DateTime min = DateTime.MaxValue;
        GameData mindata = null;
        foreach (GameData gd in userGames)
        {
            if (gd.LastPlayed < min)
            {
                min = gd.LastPlayed;
                mindata = gd;
            }
        }
        return mindata;
    }

    public int getGamesCount()
    {
        return userGames.Count;
    }

}
