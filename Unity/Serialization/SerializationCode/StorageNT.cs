using System;
using Newtonsoft.Json;
using UnityEngine;
// https://code-maze.com/csharp-deserialize-json-into-dynamic-object/

public class StorageNT
{
    public static T LoadData<T>() where T : GameData, new()
    {
        var name = typeof(T).Name;
        Debug.Log($"Loading {name}");
        if(!PlayerPrefs.HasKey(name))
        {
            var dataObject = new T();
            SaveData(dataObject);
            return dataObject;
        }

        var objectString = PlayerPrefs.GetString(name);
        var desserializedObject = JsonConvert.DeserializeObject<T>(objectString);

        return desserializedObject;
    }

    public static void SaveData(GameData data)
    {
        var stringData = JsonConvert.SerializeObject(data);
        var name = data.GetType().Name;
        PlayerPrefs.SetString(name, stringData);
        Debug.Log($"Saved {name} {stringData}");
    }

    // if we use UnityEngine object there were an error 
    // works without Serializeble attribute and inherete from System.Object

    public class GameData : System.Object 
    {

    }

    public class GameSettings : GameData
    {
        public int DeathsOnColonyEpidemic = 10;
        public int ColoniesAmount = 10;

        public GameSettings()
        {

        }
    }
}
