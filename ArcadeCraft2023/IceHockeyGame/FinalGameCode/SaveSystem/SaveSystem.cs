using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveScore (PointManager HighScore)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/topScore.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(HighScore);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static GameData LoadScore()
    {
        string path = Application.persistentDataPath + "/topScore.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;

            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
}