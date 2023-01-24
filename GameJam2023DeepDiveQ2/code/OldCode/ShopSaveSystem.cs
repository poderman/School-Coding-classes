using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class ShopSaveSystem
{
    public static void SaveShop(ShopManager items)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/shopmanager.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        ShopData data = new ShopData(items);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static void SaveShop(RespawnScript items)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/shopmanager.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        ShopData data = new ShopData(items);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static ShopData LoadShop()
    {
        string path = Application.persistentDataPath + "/shopmanager.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ShopData data = formatter.Deserialize(stream) as ShopData;

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
