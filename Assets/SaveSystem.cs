
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(Player p)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.edenstower";
        FileStream stream = new FileStream(path,FileMode.Create);
        PlayerData data = new PlayerData(p);
        formatter.Serialize(stream, data);
        stream.Close();

        Debug.Log("Se guardó el personaje en: " + path);
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.edenstower";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData pd = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            Debug.Log("Se cargó el personaje en: " + path);
            return pd;
        }
        else
        {
            Debug.LogError("No hay jugador guardado");
            return null;
        }
    }
}
