using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

public class WriteJson : MonoBehaviour
{
    public GameStatus gameStatus;
    public GameObject[] objects;
    void Start()
    {
        gameStatus = new GameStatus();
        gameStatus.statusList = new Refencenes[objects.Length];
        gameStatus.gameName = "JSON Write Test";

        for (int i = 0; i < objects.Length; i++)
        {
            gameStatus.statusList[i] = new Refencenes(); 
            gameStatus.statusList[i].id = i;
            gameStatus.statusList[i].name = objects[i].name;
        }
    }
	
    public void SaveJson()
    {
        string json = JsonUtility.ToJson(gameStatus);
        string savePath = Application.dataPath + "/Resources/Test01.json";
        File.WriteAllText(savePath, json, Encoding.UTF8);        
        
        Debug.Log("save:::" + savePath);
    }
}
