using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public int gameID;
    public Player player;
    public Difficulty difficulty;
    public int progress;

    public int timeElapsed;
    public DateTime lastPlayed;
    public Boolean isPaused;

    public enum Difficulty
    {
        Easy, Normal, Hard, Hell
    }

    void Awake()
    {
        player = GetComponentInChildren<Player>();
    }

    void Start()
    {
        lastPlayed = DateTime.Now;
        StartCoroutine(UpdateTimer());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SaveGame();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            LoadGame(1);
        }
    }

    private IEnumerator UpdateTimer()
    {
        while (true)
        {
            if(!isPaused) 
            timeElapsed += 1;
            yield return new WaitForSeconds(1);
        }
    }

    public void SaveGame()
    {
        SaveSystem.SaveGame(this);
    }

    public void LoadGame(int GameID)
    {
        GameData gd = SaveSystem.LoadGame(gameID);
        player.LoadPlayer(gd.Player);
        switch (gd.Difficulty)
        {
            case "Easy":
                difficulty = Game.Difficulty.Easy;
                break;
            case "Normal":
                difficulty = Game.Difficulty.Normal;
                break;
            case "Hard":
                difficulty = Game.Difficulty.Hard;
                break;
            case "Hell":
                difficulty = Game.Difficulty.Hell;
                break;
        }
        progress = gd.Progress;
        timeElapsed = gd.TimeElapsed;
        lastPlayed = gd.LastPlayed;
        isPaused = false;
    }




}
