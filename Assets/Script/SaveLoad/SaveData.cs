using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class SaveData 
{
    public enum Difficulty
    {
        Easy, Normal, Hard, Hell
    }
    public PlayerStats playerData = new PlayerStats();
    public ItemInventory dictMarketItems;
    public bool bgmEnabled;
    public int bgmLvl;
    public bool seEnabled;
    public int seLvl;
    public bool autoSave;
    public bool Fullscreen;
    public int gammalvl;
    // Game Difficulty
    public Difficulty difficulty;
}
