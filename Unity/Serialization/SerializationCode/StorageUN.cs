using System;
using UnityEngine;

public class StorageUN 
{
    public static T LoadData<T>() where T : GameData, new()
    {
        var name = typeof(T).Name;
        Debug.Log($"Loading UN {name}");
        if(!PlayerPrefs.HasKey(name))
        {
            var dataObject = new T();
            SaveData(dataObject);
            return dataObject;
        }

        var objectString = PlayerPrefs.GetString(name);
        var desserializedObject = JsonUtility.FromJson<T>(objectString);

        return desserializedObject;
    }

    public static void SaveData(GameData data)
    {
        var stringData = JsonUtility.ToJson(data);
        var name = data.GetType().Name;
        PlayerPrefs.SetString(name, stringData);
        Debug.Log($"Saved UN {name} {stringData}");
    }

    //for UnityEngine ArgumentException: JsonUtility.ToJson does not support engine types.
    [Serializable]
    public class GameData : UnityEngine.Object 
    {

    }

    [Serializable]
    public class GameSettings : GameData
    {
        public int DeathsOnColonyEpidemic = 10;
        public int ColoniesAmount = 10;

        public GameSettings()
        {

        }
    }
}
