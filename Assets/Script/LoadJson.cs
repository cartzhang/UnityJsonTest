using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class LoadJson : MonoBehaviour
{
    public static GameStatus LoadJsonFromFile()
    {
        BinaryFormatter bf = new BinaryFormatter();

        if (!File.Exists(Application.dataPath + "/Resources/Test.json"))
        {
            return null;
        }

        StreamReader sr = new StreamReader(Application.dataPath + "/Resources/Test.json");

        //FileStream file = File.Open(Application.dataPath + "/Test.json", FileMode.Open, FileAccess.ReadWrite);
        //if (file.Length == 0)
        //{
        //    return null;
        //}

        //string json = (string)bf.Deserialize(file);
        //file.Close();

        if (sr == null)
        {
            return null;
        }
        string json = sr.ReadToEnd();
        Debug.Log(json);
        if (json.Length > 0)
        {
            return JsonUtility.FromJson<GameStatus>(json);
        }

        return null;
    }
}
