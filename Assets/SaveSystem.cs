using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{

    public static void SaveGame(Game g)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Games/" + g.gameID.ToString()+ ".edenstower";
        FileStream stream = new FileStream(path, FileMode.Create);
        GameData data = new GameData(g);
        formatter.Serialize(stream, data);
        stream.Close();

        Debug.Log("Se guardó la partida en: " + path);
    }

    public static GameData LoadGame(int GameID)
    {
        string path = Application.persistentDataPath + "/Games/" + GameID.ToString() + ".edenstower";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            GameData gd = formatter.Deserialize(stream) as GameData;
            stream.Close();
            Debug.Log("Se cargó la partida en: " + path);
            return gd;
        }
        else
        {
            Debug.LogError("No existe la partida #" + GameID.ToString());
            return null;
        }
    }

    private static string getGamePath(int gameId)
    {
        return Application.persistentDataPath + "/Games/" + gameId.ToString() + ".edenstower";
    }


    public static List<GameData> getAllGames()
    {
        List<GameData> games = new List<GameData>();
        for(int i = 0; i < 3; i++)
        {
            string path = getGamePath(i);
            if (File.Exists(path))
            {
                games.Add(LoadGame(i));
            }
            else
                break;
        }
        return games;
    }
}
