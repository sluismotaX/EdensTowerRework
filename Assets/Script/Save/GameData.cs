using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    private int gameID;
    private PlayerData player;
    private string difficulty;
    private int progress;
    private int timeElapsed;
    private DateTime lastPlayed;

    public GameData(Game g)
    {
        gameID = g.gameID;
        player = new PlayerData(g.player);
        difficulty = g.difficulty.ToString();
        progress = g.progress;
        timeElapsed = g.timeElapsed;
        lastPlayed = g.lastPlayed;
    }

    public int GameID { get => gameID; set => gameID = value; }
    public PlayerData Player { get => player; set => player = value; }
    public string Difficulty { get => difficulty; set => difficulty = value; }
    public int Progress { get => progress; set => progress = value; }
    public int TimeElapsed { get => timeElapsed; set => timeElapsed = value; }
    public DateTime LastPlayed { get => lastPlayed; set => lastPlayed = value; }
}
